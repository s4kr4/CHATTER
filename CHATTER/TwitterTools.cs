using CoreTweet;
using CoreTweet.Core;
using CoreTweet.Streaming;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHATTER
{
	static class TwitterTools
	{
		private static Properties.Settings settings;
		private static string consumerKey;
		private static string consumerSecret;
		private static Tokens tokens;
		public static List<MentionFrame> mentionFrameList;
		public static MainFrame mainFrame;

		static TwitterTools()
		{
		}

		//OAuth認証
		public static void Authentication()
		{
			settings = Properties.Settings.Default;
			mentionFrameList = new List<MentionFrame>();

			var configFile = @"secrets.config";
			var exeFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
			var config = ConfigurationManager.OpenMappedExeConfiguration(exeFileMap, ConfigurationUserLevel.None);
			consumerKey = config.AppSettings.Settings["ConsumerKey"].Value;
			consumerSecret = config.AppSettings.Settings["ConsumerSecret"].Value;

			//settings.Reset();

			if (!string.IsNullOrEmpty(settings.AccessToken)
				&& !string.IsNullOrEmpty(settings.AccessTokenSecret))
			{
				// 認証済みなら、保存済みのトークンからインスタンス生成
				tokens = Tokens.Create(
					settings.ConsumerKey,
					settings.ConsumerSecret,
					settings.AccessToken,
					settings.AccessTokenSecret
				);
			}
			else
			{
				// 未認証の場合、新規認証
				var session = OAuth.Authorize(consumerKey, consumerSecret);
				var uri = session.AuthorizeUri;

				Process.Start(uri.AbsoluteUri);

				// 認証フレームを開く
				OAuthFrame oauthFrame = new OAuthFrame();
				oauthFrame.ShowDialog();

				try
				{
					tokens = OAuth.GetTokens(session, oauthFrame.pin);

					settings.AccessToken = tokens.AccessToken;
					settings.AccessTokenSecret = tokens.AccessTokenSecret;
					settings.UserId = tokens.UserId;
					settings.ScreenName = tokens.ScreenName;
					settings.Save();
				}
				catch (FormatException)
				{
					MessageBox.Show("PINコードを正しく入力してください");
					Environment.Exit(0);
				}
				finally
				{
					oauthFrame.Dispose();
				}
			}

			// メインフレームを開く
			Application.Run(new MainFrame());
		}

		public static User AuthorizedUser()
		{
			return tokens.Account.VerifyCredentials();
		}

		// ユーザー情報取得
		public async static Task<User> ShowUser(long? user_id = null, string screen_name = null)
		{
			if (tokens != null)
			{
				User user = null;

				try
				{
					if (user_id != null)
					{
						user = await tokens.Users.ShowAsync(user_id: (long)user_id);
					}
					else if (screen_name != null)
					{
						user = await tokens.Users.ShowAsync(screen_name: screen_name);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return null;
				}

				if (user != null)
				{
					return user;
				}
				else
				{
					MessageBox.Show("照会失敗");
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		// ツイートを奏神
		public async static Task<Status> UpdateStatus(string text, long? reply_status_id = null, List<string> media_info = null)
		{
			if (tokens != null)
			{
				Status updatedStatus;

				try
				{
					if (media_info == null)
					{
						updatedStatus = await tokens.Statuses.UpdateAsync(status: text, in_reply_to_status_id: reply_status_id);
					}
					else
					{
						MediaUploadResult[] res = await Task.WhenAll(
							media_info.Where(x => x != "").Select(x => tokens.Media.UploadAsync(new FileInfo(x)))
						);
						updatedStatus = await tokens.Statuses.UpdateAsync(status: text, in_reply_to_status_id: reply_status_id, media_ids: res.Select(x => x.MediaId));
					}

					return updatedStatus;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		// リツイートする
		public static async Task<bool> RetweetStatus(Status status)
		{
			if (tokens != null)
			{
				try
				{
					Status updatedStatus = await tokens.Statuses.RetweetAsync(status.Id);

					if (updatedStatus != null)
					{
						return false;
					}
					else
					{
						return true;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		// DM送る
		public static async void SendDirectMessage(string screenName, string text)
		{
			DirectMessage directMessage = await tokens.DirectMessages.NewAsync(screenName, text);

			//if (res.Result == RequestResult.Success)
			//{

			//}
			//else
			//{
			//	MessageBox.Show("奏神失敗");
			//}
		}

		// ふぁぼる
		public static async Task<bool> CreateFavotire(long statusId)
		{
			if (tokens != null)
			{
				try
				{
					StatusResponse res = await tokens.Favorites.CreateAsync(id => statusId);

					if (res == null)
					{
						MessageBox.Show("御気入登録失敗");
						return false;
					}
					else
					{
						return true;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		// ツイートを消す
		public static async Task<bool> DestroyStatus(Status status)
		{
			if (tokens != null)
			{
				try
				{
					StatusResponse res = await tokens.Statuses.DestroyAsync(status.Id);

					if (res == null)
					{
						return false;
					}
					else
					{
						return true;
					}
				}
				catch (TwitterException e)
				{
					Console.WriteLine(e.Message);
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		// ホームタイムライン取得
		public static async Task<ListedResponse<Status>> GetHomeTimeline(long? maxId = null)
		{
			if (tokens != null)
			{
				ListedResponse<Status> statuses = null;

				try
				{
					if (maxId == null)
					{
						statuses = await tokens.Statuses.HomeTimelineAsync();
					}
					else
					{
						statuses = await tokens.Statuses.HomeTimelineAsync(max_id: maxId);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}

				if (statuses != null)
				{
					return statuses;
				}
				else
				{
					MessageBox.Show("タイムライン取得失敗");
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		// ユーザータイムライン取得
		public static async Task<ListedResponse<Status>> GetUserTimeline(long? userId, long? maxId = null)
		{
			if (tokens != null)
			{
				ListedResponse<Status> statuses = null;

				try
				{
					if (userId != null)
					{
						statuses = await tokens.Statuses.UserTimelineAsync(user_id: (long)userId, max_id: maxId);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return null;
				}

				if (statuses != null)
				{
					return statuses;
				}
				else
				{
					MessageBox.Show("取得失敗");
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		public static IObservable<StreamingMessage> GetUserStream()
		{
			return tokens.Streaming.UserAsObservable();
		}

		// ユーザーのお気に入りを取得
		public static async Task<ListedResponse<Status>> FavoritesList(long? userId, long? maxId = null)
		{
			if (tokens != null)
			{
				ListedResponse<Status> favorites = null;

				try
				{
					if (userId != null)
					{
						favorites = await tokens.Favorites.ListAsync(id: (long)userId, max_id: maxId);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return null;
				}

				if (favorites != null)
				{
					return favorites;
				}
				else
				{
					MessageBox.Show("取得失敗");
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		// ユーザーのフォロワーを取得
		public static async Task<Cursored<User>> FollowersList(long? userId, long? cursor = null)
		{
			if (tokens != null)
			{
				Cursored<User> users = null;

				try
				{
					if (userId != null)
					{
						users = await tokens.Followers.ListAsync(user_id: (long)userId, cursor: cursor, count: 50);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return null;
				}

				if (users != null)
				{
					return users;
				}
				else
				{
					MessageBox.Show("取得失敗");
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		// ユーザーのフォロワーを取得
		public static async Task<Cursored<User>> FriendList(long? userId, long? cursor = null)
		{
			if (tokens != null)
			{
				Cursored<User> users = null;

				try
				{
					if (userId != null)
					{
						users = await tokens.Friends.ListAsync(user_id: (long)userId, cursor: cursor, count: 50);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return null;
				}

				if (users != null)
				{
					return users;
				}
				else
				{
					MessageBox.Show("取得失敗");
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		// リプライかどうか
		public static bool IsReply(Status status)
		{
			if (status.InReplyToUserId != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// 自分宛てのリプライかどうか
		public static bool IsReplyToMe(Status status)
		{
			if (status.InReplyToUserId == Properties.Settings.Default.UserId)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static void SetReply(long statusId, string screenName)
		{
			mainFrame.SetReply(statusId, screenName);
		}
		//via取り出し用正規表現
		public static Match viaReg(string via)
		{
			string pattern = @"<a.*?>(?<via>.*?)</a>";
			return Regex.Match(via, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
		}
		//URL取り出し用正規表現
		public static Match urlReg(string via)
		{
			string pattern = @"http(s)?://([\da-zA-Z]+\.)+[\da-zA-Z]+(/[\da-zA-Z./?%&=_]*)?";
			return Regex.Match(via, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
		}
		public static Match tcoReg(string via)
		{
			string pattern = @"http(s)?://t\.co/[\da-zA-Z]+";
			return Regex.Match(via, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
		}
		//ScreenName取り出し用正規表現
		public static Match screenNameReg(string via)
		{
			string pattern = @"@(?<srcName>[a-zA-Z0-9]*)";
			return Regex.Match(via, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
		}
	}
}

