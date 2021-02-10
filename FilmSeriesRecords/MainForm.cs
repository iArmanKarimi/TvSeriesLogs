using FilmSeriesRecordsDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/* To do
 * Icon for form title
 * Add ordering functionality. 
	* add a button in toolstrip that'll show a dialog with:
		* combo box of items supporting ordering 
		* radio button: ascending/descending
 * Asynchronize updating dgv
 * Create user control for dgv in order to use it in filter form. or embed the filter inside toolstrip and put x to clear filter
 * edit form
 * info form
 * settings (theme, customize, etc) put the trigger button in toolstrip 
	* background color of dataGridView
	* don't ask for deleting
	* maybe: give an option to save columns display index. dgvSeriesList.Columns[0].DisplayIndex = 1;
	* clear all records
 * maybe: add facility to group the series 
 * statistics (e.g. watched, total series, etc) form. put the trigger button in toolstrip 
 */
namespace FilmSeriesRecords
{
	public partial class MainForm : Form
	{
		private SeriesDb db;
		public MainForm()
		{
			InitializeComponent();
			lblLoading.BackColor = dgvSeriesList.BackgroundColor; // transparent loading background
																  // Init dgv //
			dgvSeriesList.AutoGenerateColumns = false;
			var cols = dgvSeriesList.Columns;
			foreach (DataGridViewColumn col in cols)
				col.DataPropertyName = col.HeaderText;
		}
		private void Loading(bool on) => lblLoading.Visible = on;
		private void MainForm_Shown(object sender, EventArgs e)
		{
			db = new SeriesDb();
			BindAllDbToDgv();
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
		
		#region Helper UI
		struct ColNames
		{
			private const string c = "Column";
			public const string Id = c + "Id";
			public const string Name = c + "Name";
			public const string Seen = c + "Seen";
			public const string Edit = c + "Edit";
			public const string Info = c + "Info";
			public const string Notes = c + "Notes";
			public const string Delete = c + "Delete";
			public const string Seasons = c + "Seasons";
		}
		private static void ComingSoon() =>
						MessageBox.Show("Coming soon!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		private void EditSeries(DataGridViewRow row)
		{
			int id = (int)row.Cells[ColNames.Id].Value;
			var series = db.Get(id);
			if (!series.IsNull)
			{
				var form = new EditForm(series.Value, db);
				form.ShowDialog();
				if (form.Edited)
				{
					bindingSource[row.Index] = form.Series.AdaptSeries();
				}
			}
			else
			{
				MessageBox.Show("Item not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
				bindingSource.RemoveAt(row.Index);
			}
		}
		private void InfoOfSeries(DataGridViewRow row)
		{
			int id = (int)row.Cells[ColNames.Id].Value;
			ComingSoon(); return;
			if (db.ExistsById(id))
				new InfoForm(id).Show();
			else
			{
				MessageBox.Show("Item was not found!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
				bindingSource.RemoveAt(row.Index);
			}
		}
		private void DeleteSeries(DataGridViewRow row)
		{
			if (MessageBox.Show("Are you sure you want to delete this series?", string.Empty,
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				bool wasRemoved = db.Remove((int)row.Cells[ColNames.Id].Value);
				if (!wasRemoved)
					MessageBox.Show("Couldn't delete the selected item!", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
					bindingSource.RemoveAt(row.Index);
			}
		}
		private void NotesOfSeries(DataGridViewRow row) => ComingSoon();
		private void AddNewSeries(Series series)
		{
			bool existsExcludingId = db.Exists(s =>
				s.Name == series.Name &&
				s.Status == series.Status &&
				s.Seasons == series.Seasons
			);
			if (existsExcludingId)
			{
				if (MessageBox.Show("Another item with this specifications already exists.\n" +
						"Do you still want to add a new one?", "Duplicated",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					return;
			}
			else if (db.Exists(s => s.Name == series.Name))
				if (MessageBox.Show("Another item with this name already exists.\n" +
						"Do you still want to add a new one?", "Duplicated",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					return;

			int id = db.Add(series);
			series.Id = id;
			bindingSource.Add(series.AdaptSeries());
		}
		private void BindAllDbToDgv()
		{
			Loading(true);
			Update();
			dgvSeriesList.BeginInvoke(new MethodInvoker(() =>
			{
				var data = db.GetAll();
				if (data.Count() > 0)
					bindingSource.DataSource = data.AdaptAllSeries();
			}));
			Loading(false);
		}
		#endregion
		#region Events of DataGridViewSeriesList 
		private void dataGridSeriesList_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (dgvSeriesList.Columns[ColNames.Seasons].Index == e.Column.Index)
			{
				e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
				e.Handled = true;
			}
		}
		private void dataGridSeriesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var cols = (sender as DataGridView).Columns;

			if (e.RowIndex > -1)
			{
				if (cols[e.ColumnIndex] is DataGridViewImageColumn)
				{
					var row = dgvSeriesList.Rows[e.RowIndex];
					if (cols[ColNames.Edit].Index == e.ColumnIndex)
						EditSeries(row);
					else if (cols[ColNames.Info].Index == e.ColumnIndex)
						InfoOfSeries(row);
					else if (cols[ColNames.Delete].Index == e.ColumnIndex)
						DeleteSeries(row);
					else if (cols[ColNames.Notes].Index == e.ColumnIndex)
						NotesOfSeries(row);
				}
			}
		}
		#endregion
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
		}
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			db.Dispose();
		}
		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			// Responsive dgv
			dgvSeriesList.Size = new System.Drawing.Size(dgvSeriesList.Size.Width, toolStrip.Location.Y);
		}
		private void btnSettings_Click(object sender, EventArgs e) => ComingSoon();
		private void toolStripBtnFilter_Click(object sender, EventArgs e)
		{
			var fp = new FilterForm();
			fp.ShowDialog();
			if (fp.Ok)
			{
				var filtered = db.Filter(fp.SeriesName, fp.Limit, fp.CaseSensitive);
				if (filtered.Count() >= 1)
					new FilteredForm(filtered.AdaptAllSeries()).ShowDialog();
				else
					MessageBox.Show("No items were found!", "No results", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void toolStripBtnAddSeries_Click(object sender, EventArgs e)
		{
			var prompt = new PromptNewSeries();
			prompt.ShowDialog();
			if (prompt.Ok)
				AddNewSeries(new Series
				{
					Name = prompt.Title,
					Status = prompt.Status.ToSeenState(),
					Seasons = prompt.Seasons,
				});
		}
		private void toolStripBtnScrollTop_Click(object sender, EventArgs e)
		{
			if (dgvSeriesList.RowCount > 0)
				dgvSeriesList.FirstDisplayedScrollingRowIndex = 0;
			dgvSeriesList.ClearSelection();
		}
		private void toolStripBtnScrollBottom_Click(object sender, EventArgs e)
		{
			if (dgvSeriesList.RowCount > 0)
				dgvSeriesList.FirstDisplayedScrollingRowIndex = dgvSeriesList.RowCount - 1;
		}
	}
}
