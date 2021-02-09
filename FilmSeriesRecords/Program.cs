using System;
using System.Windows.Forms;

namespace FilmSeriesRecords
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			const bool DEBUG = true;
			if (DEBUG)
				MainApp();
			else
				try
				{
					MainApp();
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				};
		}
		static void MainApp()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new EditForm(1));
			//Application.Run(new MainForm());
		}
	}
}
