using FilmSeriesLogsDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FilmSeriesLogs
{
	public partial class UserControlDGV : UserControl
	{
		private SeriesDb db;
		public UserControlDGV()
		{
			InitializeComponent();
			// transparent loading background
			//lblLoading.BackColor = dgvSeriesList.BackgroundColor;
			dgv.AutoGenerateColumns = false;
			foreach (DataGridViewColumn col in dgv.Columns)
				col.DataPropertyName = col.HeaderText;
		}
		public void OnFormShown(SeriesDb db) => this.db = db;

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
		// IMPLEMENT ME //
		//private void Loading(bool on) => lblLoading.Visible = on;

		private void EditSeries(DataGridViewRow row)
		{
			int id = (int)row.Cells[ColNames.Id].Value;
			var series = db.FindById(id);
			if (!series.IsNull)
			{
				var form = new EditForm(series.Value, db);
				form.ShowDialog();
				if (form.Saved)
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
			var series = db.FindById(id);
			if (!series.IsNull)
				new InfoForm(series.Value, db).Show(this);
			else
			{
				MessageBox.Show("Item was not found!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
				bindingSource.RemoveAt(row.Index);
			}
		}
		private void DeleteSeries(DataGridViewRow row)
		{
			if (MessageBox.Show("Are you sure you want to delete this item?", string.Empty,
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
		private void NotesOfSeries(DataGridViewRow row) => new NotImplementedException();

		/// <summary>Adds new series to db & updates UI</summary>
		public void AddNewSeries(Series series)
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
		public void BindData(Func<IEnumerable<Series>> getData)
		{
			//Loading(true);
			Update();
			dgv.BeginInvoke(new MethodInvoker(() =>
			{
				var data = getData();
				if (data.Count() > 0)
					bindingSource.DataSource = data.AdaptAllSeries();
				else
					; // show a message saying: no item has been created yet
			}));
			//Loading(false);
		}
		public void BindAllDbToDgv() => BindData(db.GetAll);
		#endregion

		private void dgvSeriesList_KeyDown(object sender, KeyEventArgs e)
		{
			if (dgv.SelectedCells.Count < 1) return;

			var cell = dgv.SelectedCells[0];
			var row = dgv.Rows[cell.RowIndex];

			if (e.KeyCode == Keys.Delete)
			{
				DeleteSeries(row);
				e.Handled = true;
			}
			if (e.KeyCode == Keys.E)
			{
				EditSeries(row);
				e.Handled = true;
			}
			if (e.KeyCode == Keys.I)
			{
				InfoOfSeries(row);
				e.Handled = true;
			}
		}
		private void dataGridSeriesList_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (dgv.Columns[ColNames.Seasons].Index == e.Column.Index)
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
					var row = dgv.Rows[e.RowIndex];
					if (cols[ColNames.Edit].Index == e.ColumnIndex) EditSeries(row);
					else if (cols[ColNames.Info].Index == e.ColumnIndex) InfoOfSeries(row);
					else if (cols[ColNames.Notes].Index == e.ColumnIndex) NotesOfSeries(row);
					else if (cols[ColNames.Delete].Index == e.ColumnIndex) DeleteSeries(row);
				}
			}
		}
	}
}
