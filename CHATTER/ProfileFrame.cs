using CoreTweet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHATTER
{
	public partial class ProfileFrame : BaseFrame
	{
		private Tokens tokens;
		private User user;

		private List<TweetItem> tweetList;
		private List<TweetItem> favoriteList;
		private List<UserItem> friendList;
		private List<UserItem> followerList;
		private long? timelineMaxId = null;
		private long? favoriteMaxId = null;
		private long friendCursor = -1;
		private long followerCursor = -1;

		private enum ListMode
		{
			Tweet,
			Favorite,
			Friend,
			Follower
		}
		private ListMode listMode = ListMode.Tweet;

		private bool isLoading;

		public ProfileFrame(Tokens tokens, User user)
		{
			InitializeComponent();

			//Bitmap bmp = new Bitmap(Properties.Resources.AsamaMain);
			//Color transColor = bmp.GetPixel(0, 0);
			//BackColor = transColor;
			//TransparencyKey = transColor;

			this.tokens = tokens;
			this.user = user;
			Text = user.Name;
			isLoading = false;

			tweetList = new List<TweetItem>();
			favoriteList = new List<TweetItem>();
			friendList = new List<UserItem>();
			followerList = new List<UserItem>();
		}

		private void ProfileFrame_Load(object sender, EventArgs e)
		{
			ChangeTheme(Properties.Settings.Default.Theme);
			if (user != null)
			{
				this.ProfIcon.ImageLocation = user.ProfileImageUrl.Replace("_normal", "");
				this.UserName.Text = user.Name + " @" + user.ScreenName;
				this.Description.Text = user.Description;
				if (!string.IsNullOrEmpty(user.Url)) WebURL.Text = user.Entities.Url.Urls[0].DisplayUrl;
				if (!string.IsNullOrEmpty(user.Location)) ProfileLocation.Text = user.Location;
				this.TweetB.Text = "呟言葉\r\n" + user.StatusesCount;
				this.FavoriteB.Text = "御気入\r\n" + user.FavouritesCount;
				this.FriendB.Text = "監視中\r\n" + user.FriendsCount;
				this.FollowerB.Text = "信奉者\r\n" + user.FollowersCount;

				GetUserTimeline();
			}
		}

		//ユーザータイムライン取得
		private async void GetUserTimeline()
		{
			if (listMode != ListMode.Tweet)
			{
				ItemList.Controls.Clear();
			}

			if (!isLoading)
			{
				isLoading = true;

				var statuses = await TwitterTools.GetUserTimeline(userId: user.Id, maxId: timelineMaxId);
				if (statuses != null)
				{
					int index = 0;
					if (tweetList.Count != 0)
					{
						index = 1;
					}
					ItemList.SuspendLayout();
					for (int i = index; i < statuses.Count; i++)
					{
						tweetList.Add(new TweetItem(tokens, statuses[i], this));
						ItemList.Controls.Add(tweetList[i]);
					}
					ItemList.ResumeLayout();

					timelineMaxId = statuses[statuses.Count - 1].Id;
				}

				isLoading = false;
			}

			if (tweetList.Count != 0)
			{
				ItemList.SuspendLayout();
				foreach (var item in tweetList)
				{
					ItemList.Controls.Add(item);
				}
				ItemList.ResumeLayout();
			}
		}

		//ユーザーのお気に入り取得
		private async void GetUserFavorite()
		{
			if (listMode != ListMode.Favorite)
			{
				ItemList.Controls.Clear();
			}

			if (!isLoading)
			{
				isLoading = true;

				var favorites = await TwitterTools.FavoritesList(userId: user.Id, maxId: favoriteMaxId);
				if (favorites != null)
				{
					int index = 0;
					if (favoriteList.Count != 0)
					{
						index = 1;
					}
					ItemList.SuspendLayout();
					for (int i = index; i < favorites.Count; i++)
					{
						favoriteList.Add(new TweetItem(tokens, favorites[i], this));
						ItemList.Controls.Add(favoriteList[i]);
					}
					ItemList.ResumeLayout();

					favoriteMaxId = favorites[favorites.Count - 1].Id;
				}

				isLoading = false;
			}

			if (favoriteList.Count != 0)
			{
				ItemList.SuspendLayout();
				foreach (var item in favoriteList)
				{
					ItemList.Controls.Add(item);
				}
				ItemList.ResumeLayout();
			}
		}

		//フォロー取得
		private async void GetUserFriends()
		{
			if (listMode != ListMode.Friend)
			{
				ItemList.Controls.Clear();
			}

			if (!isLoading)
			{
				isLoading = true;

				var friends = await TwitterTools.FriendList(userId: (long)user.Id, cursor: friendCursor);

				if (friends != null)
				{
					friendCursor = friends.NextCursor;

					ItemList.SuspendLayout();
					for (int i = 0; i < friends.Count; i++)
					{
						friendList.Add(new UserItem(tokens, friends[i]));
						ItemList.Controls.Add(friendList[i]);
					}
					ItemList.ResumeLayout();
				}

				isLoading = false;
			}

			if (friendList.Count != 0)
			{
				ItemList.SuspendLayout();
				foreach (var friend in friendList)
				{
					ItemList.Controls.Add(friend);
				}
				ItemList.ResumeLayout();
			}
		}

		// フォロワー取得
		private async void GetUserFollower()
		{
			if (listMode != ListMode.Follower)
			{
				ItemList.Controls.Clear();
			}

			if (!isLoading)
			{
				isLoading = true;

				var followers = await TwitterTools.FollowersList(userId: (long)user.Id, cursor: followerCursor);

				if (followers != null)
				{
					followerCursor = followers.NextCursor;

					ItemList.SuspendLayout();
					for (int i = 0; i < followers.Count; i++)
					{
						followerList.Add(new UserItem(tokens, followers[i]));
						ItemList.Controls.Add(followerList[i]);
					}
					ItemList.ResumeLayout();
				}

				isLoading = false;
			}

			if (followerList.Count != 0)
			{
				ItemList.SuspendLayout();
				foreach (var follower in followerList)
				{
					ItemList.Controls.Add(follower);
				}
				ItemList.ResumeLayout();
			}
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

		private void TweetB_Click(object sender, EventArgs e)
		{
			GetUserTimeline();
			listMode = ListMode.Tweet;
		}

		private void FavoriteB_Click(object sender, EventArgs e)
		{
			GetUserFavorite();
			listMode = ListMode.Favorite;
		}

		private void FriendB_Click(object sender, EventArgs e)
		{
			GetUserFriends();
			listMode = ListMode.Friend;
		}

		private void FollowerB_Click(object sender, EventArgs e)
		{
			GetUserFollower();
			listMode = ListMode.Follower;
		}

		private void CloseB_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SmallizeB_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void ScreenName_KeyUp(object sender, KeyEventArgs e)
		{
			//if (this.ScreenName.Text != "" && e.KeyData == Keys.Enter)
			//{
			//	this.ItemList.Controls.Clear();

			//	TwitterResponse<TwitterUser> res = TwitterUser.Show(TwitterTools.token, this.ScreenName.Text);
			//	TwitterUser user = res.ResponseObject;
			//	ShowUserPage(user);
			//}
		}

		private void DirectMailB_Click(object sender, EventArgs e)
		{
			MentionFrame mFrame = new MentionFrame(tokens, user.ScreenName);
			mFrame.Show();
		}

		private void CursorRU_Click(object sender, EventArgs e)
		{
			ScrollableControl c = (ScrollableControl)this.ItemList;
			Point pre = c.AutoScrollPosition;
			pre.Y *= -1;
			pre.Y -= 60;
			c.AutoScrollPosition = pre;
		}

		private void CursorRD_Click(object sender, EventArgs e)
		{
			ScrollableControl c = (ScrollableControl)this.ItemList;
			Point pre = c.AutoScrollPosition;
			pre.Y *= -1;
			pre.Y += 60;
			c.AutoScrollPosition = pre;
		}

		private void DCursorRU_Click(object sender, EventArgs e)
		{
			this.ItemList.AutoScrollPosition = new Point(0, 0);
		}

		private void DCursorRD_Click(object sender, EventArgs e)
		{
			this.ItemList.AutoScrollPosition = new Point(0, 10000);
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

		private void ItemList_MouseWheel(object sender, MouseEventArgs e)
		{
			if ((ItemList.VerticalScroll.Maximum - ItemList.VerticalScroll.LargeChange) - ItemList.VerticalScroll.Value < 0)
			{
				switch (listMode)
				{
					case ListMode.Tweet:
						GetUserTimeline();
						break;
					case ListMode.Favorite:
						GetUserFavorite();
						break;
					case ListMode.Friend:
						GetUserFriends();
						break;
					case ListMode.Follower:
						GetUserFollower();
						break;
					default:
						break;
				}
			}
		}

		private void ProfIcon_Click(object sender, EventArgs e)
		{
			ImageFrame imageFrage = new ImageFrame(user.ProfileImageUrl.Replace("_normal", ""));
			imageFrage.Show();
		}
	}
}
