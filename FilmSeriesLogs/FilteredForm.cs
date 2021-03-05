using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FilmSeriesLogs
{
	public partial class FilteredForm : Form
	{
		public IEnumerable<SeriesAdapted> Result { get; }

		public FilteredForm(IEnumerable<SeriesAdapted> result)
		{
			InitializeComponent();
			Result = result;
		}

		private void FilteredForm_Shown(object sender, EventArgs e)
		{
			bindingSource.DataSource = Result;
		}
	}
}
