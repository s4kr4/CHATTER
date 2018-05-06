using CoreTweet;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;

namespace CHATTER
{
	public partial class TweetItem : UserControl
    {
		private string innerUrl;
		private MediaEntity[] mediaEntity = new MediaEntity[4];
		private PictureBox[] pictureBox = new PictureBox[4];
        private Status status;
		private User user;
		private Tokens tokens;
        private MainFrame mainFrame;
		private Control parentFrame;

        public TweetItem(Tokens tokens, Status status, Control control)
        {
            InitializeComponent();

			parentFrame = control;

            this.status = status;
			this.user = status.User;
			this.tokens = tokens;
			innerUrl = "";
			pictureBox[0] = pictureBox1;
			pictureBox[1] = pictureBox2;
			pictureBox[2] = pictureBox3;
			pictureBox[3] = pictureBox4;

			TabStop = false;

            if (status.Source.IndexOf("<a") >= 0)
            {
                Match m = TwitterTools.viaReg(status.Source);
                status.Source = m.Groups["via"].Value;
            }

			// 画像が含まれていたら表示する
            if (status.Entities.Media != null)
            {
				status.Text = status.Text.Replace(status.Entities.Media[0].Url, "");
				innerUrl = status.Entities.Media[0].ExpandedUrl;

				if (status.ExtendedEntities.Media != null)
                {
					if (status.ExtendedEntities.Media[0].Type == "animated_gif")
					{
						StartButton.BackColor = Color.Transparent;
						StartButton.Parent = pictureBox1;
						StartButton.Visible = true;
					}

					for (int i = 0; i < status.ExtendedEntities.Media.Length; i++)
					{
						mediaEntity[i] = status.ExtendedEntities.Media[i];
						pictureBox[i].ImageLocation = status.ExtendedEntities.Media[i].MediaUrl + ":small";
					}

				}
			}

			// 画像のないPictureBoxを消す
			for (int i = 0; i < pictureBox.Length; i++)
			{
				if (string.IsNullOrEmpty(pictureBox[i].ImageLocation))
				{
					Controls.Remove(pictureBox[i]);
				}
			}

			//URLを置換
			foreach (var url in status.Entities.Urls)
            {
				if (!string.IsNullOrEmpty(url.Url))
				{
					Match m = TwitterTools.urlReg(status.Entities.Urls.ToString());
					status.Text = status.Text.Replace(url.Url, url.DisplayUrl);
					innerUrl = url.ExpandedUrl;
				}
			}

			//リツイート→赤、リプライ→緑、自分宛→青
			if (status.RetweetedStatus != null)
			{
				BackColor = Color.FromArgb(50, 16, 16);

				IconFrame.ImageLocation = status.RetweetedStatus.User.ProfileImageUrl.Replace("_normal", "");
				NameLabel.Text = status.RetweetedStatus.User.Name + " @" + status.RetweetedStatus.User.ScreenName;
				TweetTextLabel.Text = status.RetweetedStatus.Text;

				retweetUserIcon.ImageLocation = status.User.ProfileImageUrl.Replace("_normal", "");
				retweetUserName.Text = "Retweeted by " + status.User.Name + " and " + status.RetweetCount.ToString() + " Users";
			}
			else
			{
				IconFrame.ImageLocation = status.User.ProfileImageUrl.Replace("_normal", "");
				NameLabel.Text = status.User.Name + " @" + status.User.ScreenName;
				TweetTextLabel.Text = WebUtility.HtmlDecode(status.Text);

				Controls.Remove(retweetUserIcon);
				Controls.Remove(retweetUserName);
			}

			if (TwitterTools.IsReply(status))
			{
				if (TwitterTools.IsReplyToMe(status))
				{
					BackColor = Color.FromArgb(16, 16, 60);
				}
				else
				{
					BackColor = Color.FromArgb(12, 55, 16);
				}
			}

			switch (parentFrame.Name)
            {
                case "MainFrame":
					mainFrame = (MainFrame)control.TopLevelControl;

					TimeLabel.Text = status.CreatedAt.LocalDateTime + " (via " + status.Source + ")";
					TimeLabel.Location = new Point(59, TweetTextLabel.Location.Y + TweetTextLabel.Size.Height + 3);

					// 画像位置調整
					for (int i = 0; i < pictureBox.Length; i++)
					{
						if (pictureBox[i] != null)
						{
							switch (i)
							{
								case 0:
									pictureBox1.Location = new Point(60, TimeLabel.Location.Y + TimeLabel.Size.Height + 3);
									break;
								case 1:
									pictureBox2.Location = new Point(216, TimeLabel.Location.Y + TimeLabel.Size.Height + 3);
									break;
								case 2:
									pictureBox3.Location =new Point(60, pictureBox1.Location.Y + pictureBox1.Size.Height + 3);
									break;
								case 3:
									pictureBox4.Location = new Point(216, pictureBox2.Location.Y + pictureBox2.Size.Height + 3);
									break;
								default:
									break;
							}
							StartButton.Location = new Point(50, 15);
						}
					}

					if (status.IsFavorited.Value) FavoriteIcon.Image = Properties.Resources.favorite_b;

                    break;

                case "ProfileFrame":
                case "MentionFrame":
					MaximumSize = new Size(240, 5000);
                    IconFrame.Size = new Size(30, 30);

                    NameLabel.Location = new Point(35, 3);

                    TweetTextLabel.Location = new Point(35, 18);
                    TweetTextLabel.MinimumSize = new Size(205, 15);
                    TweetTextLabel.MaximumSize = new Size(205, 4500);

					TimeLabel.Text = status.CreatedAt.LocalDateTime + "\n(via " + status.Source + ")";
					TimeLabel.Location = new Point(35, TweetTextLabel.Location.Y + TweetTextLabel.Size.Height + 3);

                    ReplyIcon.Location = new Point(170, TweetTextLabel.Location.Y + TweetTextLabel.Size.Height + 3);

                    RetweetIcon.Location = new Point(193, TweetTextLabel.Location.Y + TweetTextLabel.Size.Height + 3);

                    FavoriteIcon.Location = new Point(216, TweetTextLabel.Location.Y + TweetTextLabel.Size.Height + 3);

					// 画像位置調整
					for (int i = 0; i < pictureBox.Length; i++)
					{
						if (pictureBox[i] != null)
						{
							pictureBox[i].Size = new Size(120, 64);
							switch (i)
							{
								case 0:
									pictureBox1.Location =
										new Point(IconFrame.Location.X, TimeLabel.Location.Y + TimeLabel.Size.Height + 3);
									break;
								case 1:
									pictureBox2.Location =
										new Point(pictureBox1.Location.X + pictureBox1.Size.Width + 4, TimeLabel.Location.Y + TimeLabel.Size.Height + 3);
									break;
								case 2:
									pictureBox3.Location =
										new Point(pictureBox1.Location.X, pictureBox1.Location.Y + pictureBox1.Size.Height + 3);
									break;
								case 3:
									pictureBox4.Location =
										new Point(pictureBox3.Location.X + pictureBox3.Size.Width + 4, pictureBox1.Location.Y + pictureBox1.Size.Height + 3);
									break;
								default:
									break;
							}
							StartButton.Location = new Point(35, 7);
						}
					}

                    break;

                default:
                    break;
            }

			// リツイートユーザー情報の位置調整
			if (status.Entities.Media != null && status.ExtendedEntities.Media != null)
			{
				switch (status.ExtendedEntities.Media.Length)
				{
					case 1:
					case 2:
						retweetUserIcon.Location = new Point(3, pictureBox1.Location.Y + pictureBox1.Size.Height + 3);
						retweetUserName.Location = new Point(40, pictureBox1.Location.Y + pictureBox1.Size.Height + 3);
						break;
					case 3:
					case 4:
						retweetUserIcon.Location = new Point(3, pictureBox3.Location.Y + pictureBox3.Size.Height + 3);
						retweetUserName.Location = new Point(40, pictureBox3.Location.Y + pictureBox3.Size.Height + 3);
						break;
				}
			}
			else
			{
				retweetUserIcon.Location = new Point(3, TimeLabel.Location.Y + TimeLabel.Size.Height + 3);
				retweetUserName.Location = new Point(40, TimeLabel.Location.Y + TimeLabel.Size.Height + 3);
			}
		}

		private async void ShowProfileFrame(User user)
		{
			ProfileFrame profileFrame = new ProfileFrame(tokens, await TwitterTools.ShowUser(user_id: user.Id));
			profileFrame.Show();
		}

		private void IconFrame_Click(object sender, EventArgs e)
        {
			if (status.RetweetedStatus == null)
			{
				ShowProfileFrame(user);
			}
			else
			{
				ShowProfileFrame(status.RetweetedStatus.User);
			}
		}

		//ContextMenu
		private void MyTweetLabel_MouseClick(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left)
			{
				if (status.User.Id == Properties.Settings.Default.UserId)
				{
					MyActionMenu.Show(this, PointToClient(Cursor.Position));
				}
				else
				{
					ActionMenu.Show(this, PointToClient(Cursor.Position));
				}
			}
		}

        private async void ActionMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
			switch (e.ClickedItem.ToString())
			{
				case "通神帯接続":
					ActionMenu.Close();

					if (innerUrl != "")
					{
						Process.Start(innerUrl);
					}
					else
					{
						MessageBox.Show("リンクが無いよ");
					}
					break;

				case "会話を表示":
					ActionMenu.Close();

					if (status.InReplyToStatusId != null)
					{
						// すでに出ているMentionFrameが無いか検索
						MentionFrame existFrame = null;
						foreach (var mentionFrame in TwitterTools.mentionFrameList)
						{
							var replies = mentionFrame.GetStatus();
							foreach (var reply in replies)
							{
								if (status.Equals(reply))
								{
									existFrame = mentionFrame;
								}
							}
						}

						// 無かったら新規に表示
						if (existFrame == null)
						{
							MentionFrame mFrame = new MentionFrame(tokens, status);
							TwitterTools.mentionFrameList.Add(mFrame);
							mFrame.Show();
						}
						else
						{
							existFrame.Activate();
						}
					}
					else
					{
						MessageBox.Show("会話が無いよ");
					}
					break;

				case "削除":
					MyActionMenu.Close();
					bool res = await TwitterTools.DestroyStatus(status);

					if (res)
					{
						BackColor = Color.FromArgb(150, 150, 150);
						NameLabel.ForeColor = Color.FromArgb(1, 1, 1);
					}
					break;
				default:
					break;
			}
		}

		private void FavoriteIcon_MouseEnter(object sender, EventArgs e)
		{
			FavoriteIcon.Image = Properties.Resources.favorite_b;
		}

		private void FavoriteIcon_MouseLeave(object sender, EventArgs e)
		{
			FavoriteIcon.Image = Properties.Resources.favorite_a;
		}

		private async void FavoriteIcon_MouseClick(object sender, MouseEventArgs e)
        {
			await TwitterTools.CreateFavotire(status.Id);
			FavoriteIcon.Image = Properties.Resources.favorite_b;
		}

		private void RetweetIcon_MouseEnter(object sender, EventArgs e)
		{
			RetweetIcon.Image = Properties.Resources.retweet_b;
		}

		private void RetweetIcon_MouseLeave(object sender, EventArgs e)
		{
			RetweetIcon.Image = Properties.Resources.retweet_a;
		}

		private async void RetweetIcon_MouseClick(object sender, MouseEventArgs e)
        {
			DialogResult result = MessageBox.Show("Retweet?", "RETWEET", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				bool res = await TwitterTools.RetweetStatus(status);

				if (res)
				{
					RetweetIcon.Image = Properties.Resources.retweet_b;
				}
			}
		}

        private void ReplyIcon_MouseEnter(object sender, EventArgs e)
        {
            ReplyIcon.Image = Properties.Resources.reply_b;
        }

        private void ReplyIcon_MouseLeave(object sender, EventArgs e)
        {
            ReplyIcon.Image = Properties.Resources.reply_a;
        }

        private void ReplyIcon_MouseClick(object sender, MouseEventArgs e)
        {
			switch (parentFrame.Name)
			{
				case "MainFrame":
					mainFrame.SetReply(status.Id, user.ScreenName);
					break;
				case "ProfileFrame":
				case "MentionFrame":
					MentionFrame mentionFrame = new MentionFrame(tokens, status);
					mentionFrame.Show();
					break;
				default:
					break;
			}
		}

		private void PictureBox_Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;

			for (int i = 0; i < mediaEntity.Length; i++)
			{
				if (mediaEntity[i] != null && (mediaEntity[i].MediaUrl + ":small") == pictureBox.ImageLocation)
				{
					ImageFrame imageFrame = new ImageFrame(mediaEntity[i]);
					imageFrame.Show();
				}
			}
		}

		private void NameLabel_Click(object sender, EventArgs e)
		{
			if (status.RetweetedStatus == null)
			{
				ShowProfileFrame(user);
			}
			else
			{
				ShowProfileFrame(status.RetweetedStatus.User);
			}
		}

		private void retweetUserIcon_Click(object sender, EventArgs e)
		{
			ShowProfileFrame(user);
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			ImageFrame imageFrame = new ImageFrame(mediaEntity[0]);
			imageFrame.Show();
		}
	}
}
