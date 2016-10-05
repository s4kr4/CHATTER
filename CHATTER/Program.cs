using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;

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

			TwitterTools.Authentication();
		}
	}
}
