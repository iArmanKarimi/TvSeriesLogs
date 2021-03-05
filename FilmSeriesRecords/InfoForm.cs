using FilmSeriesLogsDb;
using System;
using System.Windows.Forms;

namespace FilmSeriesLogs
{
	public partial class InfoForm : Form
	{
		private readonly Series series;
		private readonly SeriesDb db;
		public InfoForm(Series series, SeriesDb db)
		{
			InitializeComponent();
			this.db = db;
			this.series = series;
		}
		private void InfoForm_Shown(object sender, EventArgs e) => SetData();

		private void SetData()
		{
			txtboxName.Text = series.Name;
			txtboxStatus.Text = series.Status.ToFormString();
			txtboxSeasons.Text = series.Seasons.ToString();
			if (series.Schedule != null)
			{
				txtboxScheduleSeason.Text = series.Schedule.Season.ToString();
				txtboxScheduleEpisode.Text = series.Schedule.Episode.ToString();
				if (series.Schedule.InterruptionTime.HasValue)
					txtboxScheduleInterruptionTime.Text = series.Schedule.InterruptionTime.Value.ToString("HH:mm:ss");
				if (series.Schedule.WhenNextShowStarts.HasValue)
				{
					txtboxScheduleStartsAtDate.Text = series.Schedule.WhenNextShowStarts.Value.ToLongDateString();
					txtboxScheduleStartsAtTime.Text = series.Schedule.WhenNextShowStarts.Value.ToLongTimeString();
				}
			}
			if (series.Detail != null)
			{
				if (series.Detail.IsFavorite)
					btnFavorite.Image = Properties.Resources.icon_star_filled.ToBitmap();
				richTextBoxGenres.Text = series.Detail.Genres;
				richTextBoxDescription.Text = series.Detail.Description;
				txtboxDetailTimesWatched.Text = series.Detail.TimesWatched.ToString();
			}
		}

		private void InfoForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
	}
}
