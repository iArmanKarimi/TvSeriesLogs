using LiteDB;
using FilmSeriesRecordsDb.Helper;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

// Todo
// Implement filter
namespace FilmSeriesRecordsDb
{
	public class SeriesDb : IDisposable
	{
		private LiteDatabase db;
		private ILiteCollection<Series> collection;
		private const string FILE = "series.db";
		private const string COLL_SERIES = "series";
		public SeriesDb()
		{
			db = new LiteDatabase(FILE);
			collection = db.GetCollection<Series>(COLL_SERIES);
			collection.EnsureIndex(c => c.Name);
		}

		public Option<Series> Get(int id)
		{
			var series = collection.FindById(id);
			return new Option<Series>
			{
				Value = series,
				IsNull = series == null,
			};
		}
		public Option<Series> FindOne(Expression<Func<Series, bool>> func)
		{
			var series = collection.FindOne(func);
			return new Option<Series>
			{
				Value = series,
				IsNull = series == null,
			};
		}

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
		public IEnumerable<Series> Filter(string name, ushort limit, bool caseSensitive, bool orderByIndwx = true)
		{
			var items = GetAll();
			var filtered = items.Where(FilterPredicate);
			if (orderByIndwx)
				filtered = filtered.OrderBy(i => i.Name.IndexOf(name));

			bool FilterPredicate(Series series) =>
				caseSensitive
				? series.Name.Contains(name)
				: series.Name.ToLower().Contains(name.ToLower());

			return filtered.Take(limit);
		}
		public void Dispose() => db.Dispose();
	}
}
