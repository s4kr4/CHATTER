using CoreTweet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHATTER
{
	public partial class AsamaFrame : BaseFrame
	{
		private User user;

		public AsamaFrame()
		{
			InitializeComponent();
			Console.WriteLine("asama");
		}

		private async void AsamaFrame_Load(object sender, EventArgs e)
		{
			user = await TwitterTools.UsersShow(Properties.Settings.Default.UserId);
			myIcon.ImageLocation = user.ProfileImageUrl.Replace("_normal", "");

		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SmallizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		//文字数表示変更
		private void TweetBox_TextChanged(object sender, EventArgs e)
		{
			SendButton.Text = "奏神\n" + (140 - TweetBox.TextLength).ToString();

			//StringCount.Text = (140 - TweetBox.TextLength).ToString();

			// Replyモード時にテキストを全消去するとTweetモードに戻る
			//if (TweetBox.TextLength == 0 && sendMode == SendMode.Reply)
			//{
			//	sendMode = SendMode.Tweet;
			//}
		}
	}
}
