using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Windows.Forms;
using FilmSeriesRecordsDB.Helper;
using FilmSeriesRecordsDB;

namespace FilmSeriesRecords
{
	public static class ConvertExtension
	{
		public static SeenStatus ToSeenState(this CheckState status)
		{
			switch (status)
			{
				case CheckState.Unchecked:
					return SeenStatus.NotSeen;
				case CheckState.Indeterminate:
					return SeenStatus.Seeing;
				case CheckState.Checked:
					return SeenStatus.Seen;
				default:
					return SeenStatus.NotSeen;
			}
		}
		public static CheckState ToCheckState(this SeenStatus status)
		{
			switch (status)
			{
				case SeenStatus.NotSeen:
					return CheckState.Unchecked;
				case SeenStatus.Seeing:
					return CheckState.Indeterminate;
				case SeenStatus.Seen:
					return CheckState.Checked;
				default:
					return CheckState.Unchecked;
			}
		}
		public static SeriesAdapted AdaptSeries(this Series series) => new SeriesAdapted(series);
		public static IEnumerable<SeriesAdapted> AdaptAllSeries(this IEnumerable<Series> series) => 
			series.Select(item => new SeriesAdapted(item));
	}
}
