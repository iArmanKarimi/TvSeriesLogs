using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TvSeriesLogs
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (Debugger.IsAttached) 
				MainApp();
			else
				try { MainApp(); }
				catch (Exception e)
				{ MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
		}
		static void MainApp()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
