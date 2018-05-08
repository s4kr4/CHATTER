﻿using System;
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

			TwitterTools.Authentication();
		}
	}
}
