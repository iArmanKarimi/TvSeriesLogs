using TvSeriesLogsDb;
using System.Windows.Forms;

namespace TvSeriesLogs
{
	public class SeriesAdapted
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ushort Seasons { get; set; }
		public CheckState Seen { get; set; }
		public SeriesAdapted(Series series)
		{
			Id = series.Id;
			Name = series.Name;
			Seasons = series.Seasons;
			Seen = series.Status.ToCheckState();
		}
	}
}
