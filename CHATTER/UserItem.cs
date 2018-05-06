using CoreTweet;
using System;
using System.Windows.Forms;

namespace CHATTER
{
	public partial class UserItem : UserControl
	{
		private User user;

		public UserItem(User user)
		{
			InitializeComponent();

			this.user = user;
			IconFrame.ImageLocation = user.ProfileImageUrl;
			NameLabel.Text = user.Name + " @" + user.ScreenName;
			DescriptionLabel.Text = user.Description;
		}

		private void IconFrame_Click(object sender, EventArgs e)
		{
			ProfileFrame pFrame = new ProfileFrame(user);
			pFrame.Show();
		}

		private void NameLabel_Click(object sender, EventArgs e)
		{
			ProfileFrame pFrame = new ProfileFrame(user);
			pFrame.Show();
		}
	}
}
