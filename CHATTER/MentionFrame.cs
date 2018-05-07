using CoreTweet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHATTER
{
	public partial class MentionFrame : BaseFrame
	{
		private string targetScreenName;
		private Status status;
		private int MaxLength;
		private List<Status> replies = new List<Status>();

		enum Mode
		{
			DirectMessage,
			Reply
		}
		private Mode mode;

		public MentionFrame()
		{
			InitializeComponent();

			ChangeTheme(Properties.Settings.Default.Theme);
        }

		// Case: DM
		public MentionFrame(string targetScreenName)
		{
			InitializeComponent();

			ChangeTheme(Properties.Settings.Default.Theme);

			this.targetScreenName = targetScreenName;
			mode = Mode.DirectMessage;
		}

		// Case:Reply
		public MentionFrame(Status status)
		{
			InitializeComponent();

			ChangeTheme(Properties.Settings.Default.Theme);

			this.status = status;
			mode = Mode.Reply;
		}

		private async void MentionFrame_Load(object sender, EventArgs e)
		{
			switch (mode)
			{
				case Mode.DirectMessage:
					//MaxLength = 280;

					//for (int i = 0; i < 20; i++)
					//{
					//	DMView[i] = new MyTweetLabel();
					//}

					//DirectMessagesOptions opt = new DirectMessagesOptions()
					//{

					//};
					//TwitterResponse<TwitterDirectMessageCollection> res = TwitterDirectMessage.DirectMessages(TwitterTools.token, opt);
					//int n = res.ResponseObject.Count;
					//foreach (TwitterDirectMessage status in res.ResponseObject)
					//{
					//	n--;
					//	this.DMView[n].AutoSize = true;
					//	this.DMView[n].Font = new Font("Meiryo UI", 9);
					//	this.DMView[n].BackColor = Color.Black;
					//	this.DMView[n].ForeColor = Color.White;
					//	this.DMView[n].MinimumSize = new Size(240, 50);
					//	this.DMView[n].MaximumSize = new Size(240, 500);
					//	this.DMView[n].Margin = new Padding(3, 3, 0, 5);
					//	this.DMView[n].Text = status.Sender.Name + "\n" + status.Text;
					//	//						this.DMView[n].UserName = status.Sender.Name;
					//	this.MentionList.Controls.Add(DMView[n]);
					//}

					break;

				case Mode.Reply:
					MaxLength = 140;
					StringCount.Text = "140";

					// 自身を追加してからリプライを追加していく
					replies.Add(status);
					MentionList.Controls.Add(new TweetItem(status, this));

					await GetReply(status);

					SetReply();
					break;

				default:
					break;
			}
		}

		private async Task GetReply(Status status)
		{
			try
			{
				if (status.InReplyToStatusId != null)
				{
					Status replyStatus = await TwitterTools.ShowStatus(id: (long)status.InReplyToStatusId);
					replies.Add(replyStatus);

					MentionList.SuspendLayout();
					MentionList.Controls.Add(new TweetItem(replyStatus, this));
					MentionList.ResumeLayout();

					await GetReply(replyStatus);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		private void SetReply()
		{
			SendButton.Text = "返神";
			InputBox.Text = "@" + status.User.ScreenName + " ";
			InputBox.Focus();
			InputBox.Select(InputBox.Text.Length, 0);
		}

		private async void SendMessage()
		{
			Status res = null;

			if (InputBox.Text != "")
			{
				switch (mode)
				{
					case Mode.DirectMessage:
						TwitterTools.SendDirectMessage(InputBox.Text, targetScreenName);
						break;

					case Mode.Reply:
						res = await TwitterTools.UpdateStatus(InputBox.Text, status.Id);
						break;

					default:
						break;
				}

			}

			if (res != null)
			{
				AddNewStatus(res);
				this.InputBox.Clear();
			}
			else
			{
				MessageBox.Show("奏神失敗");
			}
		}

		public List<Status> GetStatus()
		{
			return replies;
		}

		public void AddNewStatus(Status status)
		{
			MentionList.SuspendLayout();
			replies.Add(status);
			var newTweet = new TweetItem(status, this);
            MentionList.Controls.Add(newTweet);
			MentionList.Controls.SetChildIndex(newTweet, 0);
			MentionList.ResumeLayout();

			this.status = status;
		}

		private void ChangeTheme(int religious)
		{
			switch (religious)
			{
				case (int)MainFrame.Religious.Asama:
					BackgroundImage = Properties.Resources.AsamaProfile;
					break;
				case (int)MainFrame.Religious.Sanct:
					BackgroundImage = Properties.Resources.SanctProfile;
					break;
				case (int)MainFrame.Religious.Common:
					BackgroundImage = Properties.Resources.CommonProfile;
					break;
				default:
					break;
			}
		}

		//文字数表示変更
		private void MessageBox_TextChanged(object sender, EventArgs e)
		{
			this.StringCount.Text = (MaxLength - this.InputBox.TextLength).ToString();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SmallizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void SendButton_Click(object sender, EventArgs e)
		{
			SendMessage();
		}

		//Ctrl + Enter for send message
		private void MessageBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && e.Control)
			{
				SendMessage();
			}
		}

		private void CursorRU_Click(object sender, EventArgs e)
		{
			ScrollableControl c = (ScrollableControl)this.MentionList;
			Point pre = c.AutoScrollPosition;
			pre.Y *= -1;
			pre.Y -= 60;
			c.AutoScrollPosition = pre;
		}
		private void CursorRD_Click(object sender, EventArgs e)
		{
			ScrollableControl c = (ScrollableControl)this.MentionList;
			Point pre = c.AutoScrollPosition;
			pre.Y *= -1;
			pre.Y += 60;
			c.AutoScrollPosition = pre;
		}
		private void DCursorRU_Click(object sender, EventArgs e)
		{
			this.MentionList.AutoScrollPosition = new Point(0, 0);
		}
		private void DCursorRD_Click(object sender, EventArgs e)
		{
			this.MentionList.AutoScrollPosition = new Point(0, 10000);
		}

		private void CursorLU_Click(object sender, EventArgs e)
		{
			if (this.Opacity < 1.0D)
			{
				this.Opacity += 0.1D;
			}
		}
		private void CursorLD_Click(object sender, EventArgs e)
		{
			if (this.Opacity > 0.2D)
			{
				this.Opacity -= 0.1D;
			}
		}

		private void MentionFrame_FormClosing(object sender, FormClosingEventArgs e)
		{
			TwitterTools.mentionFrameList.Remove(this);
		}
	}
}
