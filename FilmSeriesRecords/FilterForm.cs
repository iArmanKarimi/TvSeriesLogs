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
	public partial class FilterForm : Form
	{
		public bool Ok { get; private set; } = false;
		public ushort Limit => (ushort)numericUpDownFilterLimit.Value;
		public string SeriesName => txtboxFilter.Text;
		public bool CaseSensitive => checkBoxFilterCaseSensitive.Checked;
		public FilterForm()
		{
			InitializeComponent();
		}

		private void btnFilterSubmit_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtboxFilter.Text))
			{
				Ok = true;
				Close();
			}
		}
		private void FilterForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Ok = false;
				Close();
			}
		}
		private void txtboxFilter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnFilterSubmit.PerformClick();
				// avoid selection of all characters behavior
				txtboxFilter.Select(txtboxFilter.Text.Length, 0);
				txtboxFilter.Focus();
				e.Handled = e.SuppressKeyPress = true;
			}
		}
	}
}
