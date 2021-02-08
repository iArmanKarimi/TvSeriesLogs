using LiteDB;
using FilmSeriesRecordsDB.Helper;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

// Todo
// Implement filter
namespace FilmSeriesRecordsDB
{
	public class SeriesDB : IDisposable
	{
		private LiteDatabase db;
		private ILiteCollection<Series> collection;
		private const string FILE = "series.db";
		private const string COLL_SERIES = "series";
		public SeriesDB()
		{
			db = new LiteDatabase(FILE);
			collection = db.GetCollection<Series>(COLL_SERIES);
			collection.EnsureIndex(c => c.Name);
		}

		public Option<Series> Get(int id)
		{
			var series = collection.FindOne(i => i.Id == id);
			return new Option<Series>
			{
				Value = series,
				IsNull = series == null,
			};
		}
		public Series FindOne(Expression<Func<Series, bool>>func) => collection.FindOne(func);
		/// <returns>Number of items that were removed</returns>
		public bool Remove(int id) => collection.Delete(id);
		public int RemoveAll() => collection.DeleteAll();
		public bool ExistsById(int id) => collection.Exists(s => s.Id == id);
		public bool Exists(Expression<Func<Series, bool>> func) => collection.Exists(func);
		/// <returns>Id of the added series</returns>
		public int Add(Series series) => collection.Insert(series);
		/// <summary>updates considering the id</summary>
		/// <returns>false if document wasn't found in collection</returns>
		public bool Update(Series series) => collection.Update(series);
		/// <summary>updates considering the id</summary>
		/// <returns>false if document wasn't found in collection</returns>
		public bool Update(int id, Series series) => collection.Update(id, series);
		public IEnumerable<Series> GetAll() => collection.FindAll();
		public IEnumerable<Series> Filter(string name, ushort limit, bool caseSensitive)
		{
			var items = GetAll();
			var filtered = items
					.Where(FilterPredicate)
					.OrderBy(i => i.Name.IndexOf(name))
					.Take(limit);

			bool FilterPredicate(Series series) =>
				caseSensitive
				? series.Name.Contains(name)
				: series.Name.ToLower().Contains(name.ToLower());

			return filtered;
		}
		public void Dispose() => db.Dispose();
	}
}
