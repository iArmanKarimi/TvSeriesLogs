using System;
using System.Windows.Forms;

namespace FilmSeriesRecords
{
	public partial class PromptNewSeries : Form
	{
		internal bool Ok { get; private set; } = false;
		internal string Title => txtboxName.Text;
		internal ushort Seasons => (ushort)numericUpDownSeasons.Value;
		internal CheckState Status => comboBoxStatus.ToCheckState();
		public PromptNewSeries()
		{
			InitializeComponent();
			comboBoxStatus.SelectedIndex = 0;
		}

		private void PromptNewSeries_Shown(object sender, EventArgs e) => txtboxName.Focus();
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtboxName.Text) && !string.IsNullOrWhiteSpace(txtboxName.Text))
			{
				Ok = true;
				txtboxName.Text.Trim();
				Close();
			}
			else
			{
				MessageBox.Show("Name field is empty!",
					"Empty field",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				txtboxName.Focus();
			}
		}
		private void txtboxName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSubmit.PerformClick();
				e.Handled = true;
			}
		}
		private void PromptNewSeries_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Ok = false;
				Close();
			}
		}
	}
}
