using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;
using CoreTweet.Streaming;
using CoreTweet.Streaming.Reactive;
using System.Reactive.Linq;
using System.IO;
using CoreTweet.Core;
using System.Collections;
using System.Windows.Threading;

namespace CHATTER
{
    public partial class MainFrame : BaseFrame
    {
		// 取得ツイート総数
		private int tweetCount;
		// ツイート表示最大数
		private const int tweetMax = 100;

		//public Tokens Program.tokens;
		private User user;
		private TweetItem[] tweetItem;

		public enum Religious
		{
			Asama,
			Sanct,
			Common
		}
		public Religious religious;

		// ツイートのモード
		public enum SendMode
		{
			Tweet,
			Reply,
			TweetWithMedia
		}
		private SendMode sendMode;

		public List<MentionFrame> mentionFrameList;
		private PictureBox[] pictureBox;
		private List<string> fileLocation;
		private long replyStatusId;
		private long? maxId;

		private PictureBox clickedPictureBox;

		private DispatcherTimer labelTimer;

		private bool isLoading;

		private DateTime now;

		public static MainFrame mainFrame { get; set; }

        public MainFrame()
        {
            InitializeComponent();

			tweetCount = 0;
			tweetItem = new TweetItem[tweetMax];
			pictureBox = new PictureBox[4];
			fileLocation = new List<string>();

			maxId = null;
            isLoading = false;
            religious = Religious.Sanct;

			mentionFrameList = new List<MentionFrame>();

			labelTimer = new DispatcherTimer();
			labelTimer.Interval = TimeSpan.FromMilliseconds(10);
			labelTimer.Tick += new EventHandler(MoveTitleLabel);

			//Bitmap bmp = new Bitmap(Properties.Resources.AsamaMain);
			//Color transColor = bmp.GetPixel(0, 0);
			//BackColor = transColor;
			//TransparencyKey = transColor;
			//bmp.MakeTransparent(transColor);
			//BackgroundImage = bmp;
		}

		private async void MainFrame_Load(object sender, EventArgs e)
        {
			//表示枠の諸々
			ChangeTheme(Properties.Settings.Default.Theme);
			user = await TwitterTools.ShowUser(Properties.Settings.Default.UserId);
			TitleLabelA.Text = TitleLabelB.Text = "実況通神 - " + user.Name;
			myIcon.ImageLocation = user.ProfileImageUrl.Replace("_normal", "");

			GetHomeTimeline();
			StartUserstream();

			sendMode = SendMode.Tweet;

			pictureBox[0] = pictureBox1;
			pictureBox[1] = pictureBox2;
			pictureBox[2] = pictureBox3;
			pictureBox[3] = pictureBox4;

			//labelTimer.Start();
		}

		// ツイートを追加
		private void AddStatus(Status status, int position = -1)
		{
			TimeLine.SuspendLayout();

			// 表示数制限
			if (TimeLine.Controls.Count == tweetMax)
			{
				TimeLine.Controls.RemoveAt(TimeLine.Controls.Count - 1);
			}

			int i = TimeLine.Controls.Count;
			tweetItem[i] = new TweetItem(TwitterTools.tokens, status, this);
			TimeLine.Controls.Add(tweetItem[i]);

			if (position != -1)
			{
				TimeLine.Controls.SetChildIndex(tweetItem[i], position);
			}

			TimeLine.ResumeLayout();

			tweetCount++;
		}

		//通知枠に追加
		public void AddNotify(string str)
		{
			now = DateTime.Now;
			string tmp = NotificationBox.Text;
			NotificationBox.Clear();
			NotificationBox.AppendText("[" + now.ToLongTimeString() + "] " + str + "\n");
			NotificationBox.AppendText(tmp);
		}

		private async void GetHomeTimeline(long? max_id = null)
		{
			if (!isLoading)
			{
				isLoading = true;
				var status = await TwitterTools.GetHomeTimeline(max_id);

				if (status != null)
				{
					int index = 0;
					if (tweetCount != 0)
					{
						index = 1;
					}
					for (int i = index; i < status.Count; i++)
					{
						AddStatus(status[i]);
					}

					// 一番古いツイートのIDを保存しておく
					maxId = status[status.Count - 1].Id;
				}
				isLoading = false;
			}
		}

		private void StartUserstream()
		{
			var stream = TwitterTools.tokens.Streaming.UserAsObservable().Publish();

			stream.OfType<StatusMessage>().Subscribe(m => onStatus(m));

			stream.OfType<EventMessage>().Subscribe(m => onEventMessage(m));

			stream.OfType<DeleteMessage>().Subscribe(m => onDeleteMessage(m));

			stream.OfType<DisconnectMessage>().Subscribe(m => onDisconnectMessage(m));

			stream.Catch(stream.DelaySubscription(TimeSpan.FromSeconds(10)).Retry())
				.Repeat()
				.Subscribe((StreamingMessage m) => Console.WriteLine(m));

			var connection = stream.Connect();
		}

		private void onStatus(StatusMessage m)
		{
			var status = m.Status;
			Invoke((MethodInvoker)delegate
			{
				// UserStreamで流れてきたツイートは一番上(position:0)に表示する
				AddStatus(status, 0);

				if (status.InReplyToStatusId != null || status.InReplyToUserId != null)
				{
					if (TwitterTools.IsReplyToMe(status))
					{
						// すでに出ているMentionFrameが無いか検索
						MentionFrame existFrame = null;
						foreach (var mFrame in TwitterTools.mentionFrameList)
						{
							var replies = mFrame.GetStatus();
							foreach (var reply in replies)
							{
								if (status.Equals(reply))
								{
									existFrame = mFrame;
								}
								else if (status.InReplyToStatusId == reply.Id)
								{
									existFrame = mFrame;
								}
							}
						}

						// 無かったら新規に表示
						if (existFrame == null)
						{
							MentionFrame mFrame = new MentionFrame(TwitterTools.tokens, status);
							TwitterTools.mentionFrameList.Add(mFrame);
							mFrame.Show();
						}
						else
						{
							existFrame.AddNewStatus(status);
							existFrame.Activate();
						}
						existFrame = null;
					}
				}
			});

			Console.WriteLine(tweetCount + ": " + m.Status.Text);
		}

		private void onEventMessage(EventMessage m)
		{
			Invoke((MethodInvoker)delegate
			{
				switch (m.Event)
				{
					case EventCode.AccessRevoked:
						Console.WriteLine("AccessRevoked");
						break;
					case EventCode.Block:
						Console.WriteLine("Block");
						break;
					case EventCode.Unblock:
						Console.WriteLine("Unblock");
						break;
					case EventCode.Favorite:
						Console.WriteLine("Favorite");
						if (m.Source.Id != Properties.Settings.Default.UserId)
						{
							AddNotify("fav: " + m.Source.Name + " -> " + m.TargetStatus.Text);
						}
						break;
					case EventCode.Unfavorite:
						Console.WriteLine("Unfavorite");
						break;
					case EventCode.Follow:
						Console.WriteLine("Follow");
						if (m.Source.Id != Properties.Settings.Default.UserId)
						{
							AddNotify("follow: " + m.Source.Name + " -> " + m.Target.ScreenName);
						}
						break;
					case EventCode.Unfollow:
						Console.WriteLine("Unfollow");
						if (m.Source.Id != Properties.Settings.Default.UserId)
						{
							AddNotify("unfollow: " + m.Source.Name + " -> " + m.Target.ScreenName);
						}
						break;
					case EventCode.ListCreated:
						Console.WriteLine("ListCreated");
						break;
					case EventCode.ListDestroyed:
						Console.WriteLine("ListDestroyed");
						break;
					case EventCode.ListUpdated:
						Console.WriteLine("ListUpdated");
						break;
					case EventCode.ListMemberAdded:
						Console.WriteLine("ListMemberAdded");
						break;
					case EventCode.ListMemberRemoved:
						Console.WriteLine("ListMemberRemoved");
						break;
					case EventCode.ListUserSubscribed:
						Console.WriteLine("ListUserSubscribed");
						break;
					case EventCode.ListUserUnsubscribed:
						Console.WriteLine("ListUserUnsubscribed");
						break;
					case EventCode.UserUpdate:
						Console.WriteLine("UserUpdate");
						break;
					case EventCode.Mute:
						Console.WriteLine("Mute");
						break;
					case EventCode.Unmute:
						Console.WriteLine("Unmute");
						break;
					case EventCode.FavoritedRetweet:
						Console.WriteLine("FavoritedRetweet");
						break;
					case EventCode.RetweetedRetweet:
						Console.WriteLine("RetweetedRetweet");
						break;
					case EventCode.QuotedTweet:
						Console.WriteLine("QuotedTweet");
						break;
					default:
						break;
				}
			});
		}

		private void onDeleteMessage(DeleteMessage m)
		{
			Console.WriteLine(m.ToString());
		}

		private void onDisconnectMessage(DisconnectMessage e)
		{
			Console.WriteLine(e.Reason);
		}

		private async void UpdateStatus()
		{
			Status res = null;

			if (TweetBox.TextLength <= 140)
			{
				try
				{
					switch (sendMode)
					{
						// 通常のツイート
						case SendMode.Tweet:
							res = await TwitterTools.UpdateStatus(TweetBox.Text);
							break;
						// リプライ
						case SendMode.Reply:
							if (fileLocation.Count == 0)
							{
								// ただのリプライ
								res = await TwitterTools.UpdateStatus(TweetBox.Text, replyStatusId);
							}
							else
							{
								// リプライ + 画像
								res = await TwitterTools.UpdateStatus(TweetBox.Text, replyStatusId, fileLocation);
							}
							SendButton.Text = "送神" + (140 - TweetBox.TextLength).ToString();
							break;
						// 画像付きツイート
						case SendMode.TweetWithMedia:
							res = await TwitterTools.UpdateStatus(text: TweetBox.Text, media_info: fileLocation);
							break;
						default:
							break;
					}
					sendMode = SendMode.Tweet;
				}
				catch (ArgumentException e)
				{
					Console.WriteLine(e.Message);
				}

				if (res == null)
				{
					MessageBox.Show("送神失敗");
				}
				else
				{
					TweetBox.Clear();

					// 画像リセット
					for (int i = 0; i < pictureBox.Length; i++)
					{
						pictureBox[i].ImageLocation = null;
						pictureBox[i].Visible = false;
					}
					fileLocation = new List<string>();
				}
			}
			else
			{
				MessageBox.Show("文字数オーバー");
			}
		}

		private void MoveTitleLabel(object sender, EventArgs e)
		{
			if (TitleLabelA.Location.X < TitleLabelB.Location.X)
			{
				TitleLabelA.Location = new Point(TitleLabelA.Location.X - 1, 153);
				TitleLabelB.Location = new Point(TitleLabelA.Location.X + TitleLabelA.Width, 153);
				if ((TitleLabelA.Location.X + TitleLabelA.Width) < 0)
				{
					TitleLabelA.Location = new Point(TitleLabelB.Location.X + TitleLabelB.Width, 153);
				}
			}
			else
			{
				TitleLabelB.Location = new Point(TitleLabelB.Location.X - 1, 153);
				TitleLabelA.Location = new Point(TitleLabelB.Location.X + TitleLabelB.Width, 153);
				if ((TitleLabelB.Location.X + TitleLabelB.Width) < 0)
				{
					TitleLabelB.Location = new Point(TitleLabelA.Location.X + TitleLabelA.Width, 153);
				}
			}
		}

		private void ChangeTheme(int religious)
		{
			switch (religious)
			{
				case (int)Religious.Asama:
					BackgroundImage = Properties.Resources.AsamaMain;
					CursorLeftButtom.Location = new Point(82, CursorLeftButtom.Location.Y);
					CursorRightButtom.Location = new Point(686, CursorRightButtom.Location.Y);
					TweetBox.Size = new Size(504, 54);
					TweetBox.Location = new Point(118, TweetBox.Location.Y);
					SendButton.Location = new Point(628, SendButton.Location.Y);


					break;
				case (int)Religious.Sanct:
					BackgroundImage = Properties.Resources.SanctMain;
					break;
				case (int)Religious.Common:
					BackgroundImage = Properties.Resources.CommonMain;
					break;
				default:
					break;
			}
		}

		private void ChangeTheme(Religious religious)
		{
			this.ChangeTheme((int)religious);
		}

		public void SetReply(long statusId, string screenName)
		{
			replyStatusId = statusId;
			TweetBox.Text = "@" + screenName + " ";
			SendButton.Text = "返神" + (140 - TweetBox.TextLength).ToString();
			sendMode = SendMode.Reply;
			TweetBox.Focus();
			TweetBox.Select(TweetBox.Text.Length, 0);
		}

		//Ctrl + Enterでツイート送信
		private void TweetBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control)
            {
				UpdateStatus();
				e.SuppressKeyPress = true;
			}
		}

        private void TweetBox_MouseEnter(object sender, EventArgs e)
        {
			if (ActiveForm == this)
			{
				TweetBox.Focus();
			}
		}

		//送信ボタン
		private void Send_Click(object sender, EventArgs e)
        {
			UpdateStatus();
		}

		//再読込ボタン
		private void Reload_Click(object sender, EventArgs e)
        {
            TimeLine.Controls.Clear();
			GetHomeTimeline();
			maxId = null;
        }

        //マイアイコンクリックでプロフィール表示
        private async void myIcon_Click(object sender, EventArgs e)
        {
			User user = await TwitterTools.ShowUser(Properties.Settings.Default.UserId);
			ProfileFrame profileFrame = new ProfileFrame(TwitterTools.tokens, user);
			profileFrame.Show();
		}

        //マウスホイールでスクロール
        private void TimeLine_MouseWheel(object sender, MouseEventArgs e)
        {
			//if (Math.Abs(e.Delta) < 120) return;

			ScrollableControl c = (ScrollableControl)this.TimeLine;
			//var scroll = c.VerticalScroll;

			//var maximum = 1 + scroll.Maximum - scroll.LargeChange;
			//var delta = -(e.Delta / 120) * scroll.SmallChange;
			//var offset = Math.Min(Math.Max(scroll.Value + delta, scroll.Minimum), maximum);

			//c.AutoScrollPosition = new Point(0, offset);

			if (TimeLine.Controls.Count < tweetMax)
			{
				if ((c.VerticalScroll.Maximum - c.VerticalScroll.LargeChange) - c.VerticalScroll.Value < 0)
				{
					GetHomeTimeline(maxId);
				}
			}
		}

        // ScrollButton
        // Up
        private void CursorRU_Click(object sender, EventArgs e)
        {
            ScrollableControl c = (ScrollableControl)this.TimeLine;
            Point pre = c.AutoScrollPosition;
            pre.Y *= -1;
            pre.Y -= 60;
            c.AutoScrollPosition = pre;
        }
        // Down
        private void CursorRD_Click(object sender, EventArgs e)
        {
            ScrollableControl c = (ScrollableControl)this.TimeLine;
            Point pre = c.AutoScrollPosition;
            pre.Y *= -1;
            pre.Y += 60;
            c.AutoScrollPosition = pre;
        }
        // Highest
        private void DCursorRU_Click(object sender, EventArgs e)
        {
            this.TimeLine.AutoScrollPosition = new Point(0, 0);
        }
        // Lowest
        private void DCursorRD_Click(object sender, EventArgs e)
        {
            this.TimeLine.AutoScrollPosition = new Point(0, 10000);
        }

        //透過度変更ボタン
        //下げる
        private void CursorLD_Click(object sender, EventArgs e)
        {
            if (this.Opacity > 0.2D)
            {
                this.Opacity -= 0.1D;
            }
        }
        //上げる
        private void CursorLU_Click(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0D)
            {
                this.Opacity += 0.1D;
            }
        }

        //文字数表示変更
        private void TweetBox_TextChanged(object sender, EventArgs e)
        {
			SendButton.Text = "送神\n" + (140 - TweetBox.TextLength).ToString();
            //StringCount.Text = (140 - TweetBox.TextLength).ToString();

			// Replyモード時にテキストを全消去するとTweetモードに戻る
			if (TweetBox.TextLength == 0 && sendMode == SendMode.Reply)
			{
				sendMode = SendMode.Tweet;
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SmallizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void TweetBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void TweetBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
				string[] tmp = (string[])e.Data.GetData(DataFormats.FileDrop);
				FileInfo fi;

				for (int i = 0; i < tmp.Length; i++)
				{
					fi = new FileInfo(tmp[i]);
					
					if (fi.Extension == ".gif")
					{
						// gif動画は5MBまで
						if (fi.Length > 5000000)
						{
							MessageBox.Show("サイズオーバー");
							break;
						}
						else
						{
							fileLocation = new List<string>();
							for (int j = 0; j < 4; j++)
							{
								pictureBox[j].ImageLocation = null;
								pictureBox[j].Visible = false;
							}

							fileLocation.Add(tmp[i]);
							pictureBox[0].ImageLocation = tmp[i];
							pictureBox[0].Visible = true;
						}
					}
					else
					{
						// gif動画と他の画像は同時に送信できない
						if (pictureBox[0].ImageLocation != null && pictureBox[0].ImageLocation.IndexOf(".gif") != -1)
						{
							fileLocation = new List<string>();
							pictureBox[0].ImageLocation = null;
							pictureBox[0].Visible = false;
						}

						for (int j = 0; j < pictureBox.Length; j++)
						{
							if (pictureBox[j].ImageLocation == null)
							{
								fileLocation.Add(tmp[i]);
								pictureBox[j].ImageLocation = tmp[i];
								pictureBox[j].Visible = true;
								break;
							}
						}
					}
				}

				if (sendMode != SendMode.Reply)
				{
					sendMode = SendMode.TweetWithMedia;
				}
				this.Focus();
            }
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (e.X - mousePoint.X > 150)
                {
                    this.Close();
                }
            }
        }

		private void pictureBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				// どの画像がクリックされたか保存
				clickedPictureBox = (PictureBox)sender;
				UploadImageMenu.Show(this, PointToClient(Cursor.Position));
			}
		}

		private void UploadImageMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.ToString() == "取消")
			{
				UploadImageMenu.Close();

				for (int i = 0; i < fileLocation.Count; i++)
				{
					if (clickedPictureBox.ImageLocation == fileLocation[i])
					{
						fileLocation.RemoveAt(i);
					}
				}

				clickedPictureBox.ImageLocation = null;
				clickedPictureBox.Visible = false;
			}
		}

		private void Settings_Click(object sender, EventArgs e)
		{
			SettingFrame settingFrame = new SettingFrame();
			settingFrame.Show();
		}
	}
}
