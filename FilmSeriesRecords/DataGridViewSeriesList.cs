using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmSeriesLogs
{
	public partial class DataGridViewSeriesList : UserControl
	{
		public DataGridViewSeriesList()
		{
			InitializeComponent();
		}

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
		//private void dataGridSeriesList_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		//{
		//	if (dgvSeriesList.Columns[ColNames.Seasons].Index == e.Column.Index)
		//	{
		//		e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
		//		e.Handled = true;
		//	}
		//}
		//private void EditSeries(DataGridViewRow row)
		//{
		//	int id = (int)row.Cells[ColNames.Id].Value;
		//	ComingSoon();

		//	// One instance allowed for each form is overkill. one for a type is enough. //
		//	// OLD
		//	//if (!db.ExistsById(id))
		//	//{
		//	//	MessageBox.Show("Couldn't find the series.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
		//	//	return;
		//	//}
		//	//var runningForms = Application.OpenForms.OfType<EditForm>();
		//	//if (runningForms.Any(f => f.Id == id))
		//	//	if (WindowIsAlreadyOpen() == DialogResult.Yes)
		//	//		runningForms.First(f => f.Id == id)?.Close();
		//	//	else;
		//	//else
		//	//	new EditForm(id).Show();
		//}
		//private void SeriesInfo(DataGridViewRow row)
		//{
		//	int id = (int)row.Cells[ColNames.Id].Value;
		//	ComingSoon();

		//	// One instance allowed for each form is overkill. one for a type is enough. //
		//	// OLD
		//	//if (!db.ExistsById(id))
		//	//{
		//	//	MessageBox.Show("Couldn't find the series.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
		//	//	return;
		//	//}
		//	//var runningForms = Application.OpenForms.OfType<InfoForm>();
		//	//if (runningForms.Any(f => f.Id == id))
		//	//	if (WindowIsAlreadyOpen() == DialogResult.Yes)
		//	//		runningForms.First(f => f.Id == id)?.Close();
		//	//	else;
		//	//else
		//	//	new InfoForm(id).Show();
		//}
		//private void DeleteSeries(DataGridViewRow row)
		//{
		//	if (MessageBox.Show("Are you sure you want to delete this series?", string.Empty,
		//			MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		//	{
		//		bool wasRemoved = db.Remove((int)row.Cells[ColNames.Id].Value);
		//		if (!wasRemoved)
		//			MessageBox.Show("Couldn't delete the selected item!", "Warning",
		//				MessageBoxButtons.OK, MessageBoxIcon.Warning);
		//		else
		//			bindingSource.RemoveAt(row.Index);
		//	}
		//}
		//private void NotesOfSeries(DataGridViewRow row) => ComingSoon();
		//private void dataGridSeriesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		//{
		//	var cols = (sender as DataGridView).Columns;

		//	if (e.RowIndex > -1)
		//	{
		//		if (cols[e.ColumnIndex] is DataGridViewImageColumn)
		//		{
		//			var row = dgvSeriesList.Rows[e.RowIndex];
		//			if (cols[ColNames.Edit].Index == e.ColumnIndex)
		//				EditSeries(row);
		//			else if (cols[ColNames.Info].Index == e.ColumnIndex)
		//				SeriesInfo(row);
		//			else if (cols[ColNames.Delete].Index == e.ColumnIndex)
		//				DeleteSeries(row);
		//			else if (cols[ColNames.Notes].Index == e.ColumnIndex)
		//				NotesOfSeries(row);
		//		}
		//	}
		//}
	}
}
