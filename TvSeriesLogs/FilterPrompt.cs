using TvSeriesLogsDb;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TvSeriesLogs
{
	public partial class FilterPrompt : Form
	{
		private readonly SeriesDb db;
		private ushort Limit => (ushort)numericUpDownFilterLimit.Value;
		private string SearchQuery => txtboxFilter.Text;
		private bool CaseSensitive => checkBoxFilterCaseSensitive.Checked;

		public Func<DialogResult> ShowFilteredForm;
		public FilterPrompt(SeriesDb db)
		{
			this.db = db;
			InitializeComponent();
		}

		private void btnFilterSubmit_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(SearchQuery))
			{
				Func<IEnumerable<Series>> getResult = () => db.Filter(SearchQuery, Limit, CaseSensitive);
				ShowFilteredForm = new FilteredForm(db, SearchQuery, getResult).ShowDialog;
				DialogResult = DialogResult.OK;
				Close();
			}
		}
		private void FilterForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}
		private void txtboxFilter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnFilterSubmit.PerformClick();
				// avoid selection of all characters behavior //
				txtboxFilter.Select(txtboxFilter.Text.Length, 0);
				txtboxFilter.Focus();
				e.Handled = e.SuppressKeyPress = true;
			}
		}
	}
}
