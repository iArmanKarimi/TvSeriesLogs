using FilmSeriesRecordsDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* Todo
 * Add an option for interruption & StartsAt inputs to be null (user can choose it not to have any value)
 */
namespace FilmSeriesRecords
{
	public partial class EditForm : Form
	{
		public bool Saved;
		public Series Series { get; }
		private readonly SeriesDb db;
		public EditForm(Series series, SeriesDb db)
		{
			InitializeComponent();
			Series = series;
			this.db = db;
		}

		private void EditForm_Shown(object sender, EventArgs e)
		{
			SetDataFromDb();
		}
		#region Helper
		private void SetDataFromDb()
		{
			txtboxName.Text = Series.Name;
			comboBoxStatus.SelectedIndex = Series.Status.ToCheckState().ToComboBoxItem();
			numericUpDownSeasons.Value = Series.Seasons;
			if (Series.Schedule != null)
			{
				numericUpDownScheduleSeasons.Value = Series.Schedule.Season;
				numericUpDownScheduleEpisode.Value = Series.Schedule.Episode;
				if (Series.Schedule.InterruptionTime.HasValue)
					dateTimePickerInterruptionTime.Value = Series.Schedule.InterruptionTime.Value;
				if (Series.Schedule.WhenNextShowStarts.HasValue)
				{
					dateTimePickerShowStartsAtDate.Value = Series.Schedule.WhenNextShowStarts.Value;
					dateTimePickerShowStartsAtTime.Value = Series.Schedule.WhenNextShowStarts.Value;
				}
			}
		}
		private void SetDataFromFormToObject()
		{
			Series.Name = txtboxName.Text;
			Series.Status = comboBoxStatus.ToCheckState().ToSeenState();
			Series.Seasons = (ushort)numericUpDownSeasons.Value;

			if (Series.Schedule == null) Series.Schedule = new SeriesSchedule();

			Series.Schedule.Season = (ushort)numericUpDownScheduleSeasons.Value;
			Series.Schedule.Episode = (ushort)numericUpDownScheduleEpisode.Value;
			Series.Schedule.InterruptionTime = dateTimePickerInterruptionTime.Value;

			var date = dateTimePickerShowStartsAtDate.Value;
			var time = dateTimePickerShowStartsAtTime.Value.TimeOfDay;

			Series.Schedule.WhenNextShowStarts = new DateTime(
				date.Year, date.Month, date.Day,
				time.Hours, time.Minutes, time.Seconds);
		}
		#endregion
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			SetDataFromFormToObject();
			if (db.Update(Series))
			{
				MessageBox.Show("Edit has been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Saved = true;
			}
			else
			{
				MessageBox.Show("Series wasn't found!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
