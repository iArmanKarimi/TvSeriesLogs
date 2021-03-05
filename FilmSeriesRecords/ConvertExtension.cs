using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Windows.Forms;
using FilmSeriesLogsDb.Helper;
using FilmSeriesLogsDb;

namespace FilmSeriesLogs
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
		public static CheckState ToCheckState(this ComboBox comboBox)
		{
			switch (comboBox.SelectedIndex)
			{
				case 0:
					return CheckState.Unchecked;
				case 1:
					return CheckState.Indeterminate;
				case 2:
					return CheckState.Checked;
				default:
					return CheckState.Unchecked;
			}
		}
		public static int ToComboBoxItem(this CheckState state)
		{
			switch (state)
			{
				case CheckState.Unchecked:
					return 0;
				case CheckState.Indeterminate:
					return 1;
				case CheckState.Checked:
					return 2;
				default:
					return 0;
			}
		}
		public static string ToFormString(this SeenStatus status)
		{
			switch (status)
			{
				case SeenStatus.NotSeen:
					return "Haven't watched";
				case SeenStatus.Seeing:
					return "Watching";
				case SeenStatus.Seen:
					return "Watched";
				default:
					return "Haven't watched";
			}
		}
	}
}
