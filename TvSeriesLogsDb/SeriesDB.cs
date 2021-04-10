using LiteDB;
using TvSeriesLogsDb.Helper;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace TvSeriesLogsDb
{
	public class SeriesDb : IDisposable
	{
		private LiteDatabase db;
		private ILiteCollection<Series> collection;
		private const string FILE = "series.db";
		private const string APP_NAME = "TvSeriesLogs";
		private const string COLL_SERIES = "series";
		private string PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		public SeriesDb()
		{
			if (!Debugger.IsAttached)
				Directory.CreateDirectory(Path.Combine(PATH, APP_NAME));
			db = new LiteDatabase(Debugger.IsAttached ? FILE : Path.Combine(PATH, APP_NAME, FILE));
			collection = db.GetCollection<Series>(COLL_SERIES);
			collection.EnsureIndex(c => c.Name);
		}

		public Option<Series> FindById(int id)
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
		public IEnumerable<Series> Find(Expression<Func<Series, bool>> exp) => collection.Find(exp);
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
