using System;
using System.Windows.Forms;

namespace CHATTER
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// 認証
			TwitterTools.Authentication();

			// メインフレームを開く
			Application.Run(new MainFrame());
		}
	}
}
