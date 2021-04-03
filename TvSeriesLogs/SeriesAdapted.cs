using TvSeriesLogsDb;
using System.Windows.Forms;

namespace TvSeriesLogs
{
	public class SeriesAdapted
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Season { get; set; } = "-";
		public string Episode { get; set; } = "-";
		public CheckState Seen { get; set; }
		public SeriesAdapted(Series series)
		{
			Id = series.Id;
			Name = series.Name;
			Seen = series.Status.ToCheckState();
			if (series.Schedule != null)
			{
				if (series.Schedule.Season >= 0)
					Season = series.Schedule.Season.ToString();
				if (series.Schedule.Episode >= 0)
					Episode = series.Schedule.Episode.ToString();
			}
		}
	}
}
