using FilmSeriesLogsDb;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FilmSeriesLogs
{
	public partial class FilteredForm : Form
	{
		private readonly SeriesDb db;
		private readonly Func<IEnumerable<Series>> getResult;

		public FilteredForm(SeriesDb db, string query, Func<IEnumerable<Series>> getResult)
		{
			this.db = db;
			this.getResult = getResult;
			InitializeComponent();
			Text = $"Search : {query}";
		}
		private void FilteredForm_Shown(object sender, EventArgs e)
		{
			userControlDGV.OnFormShown(db);
			userControlDGV.BindData(getResult);
		}
		private void FilteredForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}
	}
}
