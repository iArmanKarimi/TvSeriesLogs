using FilmSeriesLogsDb;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FilmSeriesLogs
{
	public partial class MainForm : Form
	{
		private readonly SeriesDb db;
		public MainForm()
		{
			db = new SeriesDb();
			InitializeComponent();
		}
		//private void Loading(bool on) => lblLoading.Visible = on;
		private void MainForm_Shown(object sender, EventArgs e)
		{
			userControlDGV.OnFormShown(db);
			userControlDGV.BindAllDbToDgv();
		}
		private void TestTimeStatistics()
		{
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

			sw.Start();
			var data = db.GetAll();
			sw.Stop();
			var fetchTime = sw.ElapsedMilliseconds;
			sw.Restart();
			var adapted = data.AdaptAllSeries();
			sw.Stop();
			var adaption = sw.ElapsedMilliseconds;
			sw.Restart();
			bindingSource.DataSource = adapted;
			var bindDGV = sw.ElapsedMilliseconds;
			sw.Stop();
			var total = sw.ElapsedMilliseconds;
			string result =
				$"fetch: {fetchTime} ms\n" +
				$"adaption: {adaption} ms\n" +
				$"binding: {bindDGV} ms\n" +
				$"total: {total} ms\n" +
				$"sum: {fetchTime + adaption + bindDGV} ms";
			MessageBox.Show(result, "Result of time");
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			// search 
			if (e.Modifiers == Keys.Control && (e.KeyCode == Keys.F || e.KeyCode == Keys.S))
			{
				toolStripBtnFilter.PerformClick();
				e.Handled = true;
			}
			// new item
			if (e.Control && e.KeyCode == Keys.N)
			{
				toolStripBtnAddSeries.PerformClick();
				e.Handled = true;
			}
			// preferences (settings)
			if (e.Control && e.KeyCode == Keys.P)
			{
				//btnSettings.PerformClick();
				e.Handled = true;
			}
			// exit
			if (e.Control && e.KeyCode == Keys.W)
			{
				Close();
				e.Handled = true;
			}
		}
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => db.Dispose();
		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			// Responsive dgv UI // 
			userControlDGV.Size = new System.Drawing.Size(userControlDGV.Size.Width, toolStrip.Location.Y);
		}
		private void btnSettings_Click(object sender, EventArgs e) => new NotImplementedException();
		private void toolStripBtnFilter_Click(object sender, EventArgs e)
		{
			var prompt = new FilterPrompt(db);
			prompt.ShowDialog();
			if (prompt.DialogResult == DialogResult.OK)
				prompt.ShowFilteredForm();
		}
		private void toolStripBtnAddSeries_Click(object sender, EventArgs e)
		{
			var prompt = new PromptNewSeries();
			prompt.ShowDialog();
			if (prompt.DialogResult == DialogResult.OK)
				userControlDGV.AddNewSeries(new Series
				{
					Name = prompt.Title,
					Status = prompt.Status.ToSeenState(),
					Seasons = prompt.Seasons,
				});
		}
		private void toolStripBtnScrollTop_Click(object sender, EventArgs e) => userControlDGV.ScrollTop();
		private void toolStripBtnScrollBottom_Click(object sender, EventArgs e) => userControlDGV.ScrollBottom();
	}
}
