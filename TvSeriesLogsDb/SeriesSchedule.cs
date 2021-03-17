using System;

namespace TvSeriesLogsDb
{
	public class SeriesSchedule
	{
		public ushort Season { get; set; } // current season 
		public ushort Episode { get; set; } // episode to see next
		public DateTime? InterruptionTime { get; set; } // last time bookmarked
		public DateTime? WhenNextShowStarts { get; set; } // date & time of when the next show starts at
	}
}
