using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmSeriesRecords
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
