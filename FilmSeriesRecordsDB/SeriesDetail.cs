namespace FilmSeriesLogsDb
{
	public class SeriesDetail
	{
		public bool IsFavorite { get; set; }
		public string Genres { get; set; }
		public string Description { get; set; }
		public ushort TimesWatched { get; set; } // How many times was this series seen
	}
}