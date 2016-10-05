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
	public partial class UserItem : UserControl
	{
		private User user;
		private Tokens tokens;

		public UserItem(Tokens tokens, User user)
		{
			InitializeComponent();

			this.tokens = tokens;
			this.user = user;
			IconFrame.ImageLocation = user.ProfileImageUrl;
			NameLabel.Text = user.Name + " @" + user.ScreenName;
			DescriptionLabel.Text = user.Description;
		}

		private void IconFrame_Click(object sender, EventArgs e)
		{
			ProfileFrame pFrame = new ProfileFrame(tokens, user);
			pFrame.Show();
		}

		private void NameLabel_Click(object sender, EventArgs e)
		{
			ProfileFrame pFrame = new ProfileFrame(tokens, user);
			pFrame.Show();
		}
	}
}
