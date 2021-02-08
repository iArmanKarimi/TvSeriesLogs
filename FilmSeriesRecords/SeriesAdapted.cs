using FilmSeriesRecordsDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmSeriesRecords
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
