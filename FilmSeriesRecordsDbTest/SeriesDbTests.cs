using FilmSeriesLogsDb;
using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FilmSeriesLogsDbTest
{
	[TestFixture]
	public class SeriesDbTests
	{
		private SeriesDb db;
		private List<Series> list = new List<Series>();
		public SeriesDbTests()
		{
			db = new SeriesDb();
			for (int i = 0; i < 20; i++)
			{
				var s = new Series
				{
					Name = $"Test{(i + rand(byte.MinValue, ushort.MaxValue))}{new string('*', 6)}",
					Status = FilmSeriesLogsDb.Helper.SeenStatus.Seeing,
					Seasons = rand(1, 100),
					Schedule = null,
					Detail = null,
				};
				db.Add(s);
				list.Add(s);
			}
		}
		~SeriesDbTests()
		{
			foreach (var item in list)
				db.Remove(item.Id);
		}
		private ushort rand(ushort min, ushort max) => (ushort)new Random().Next(min, max);

		[Test]
		[NonParallelizable]
		public void Filter()
		{
			Filter(true, true);
			Filter(true, false);
			Filter(false, true);
			Filter(false, false);
		}

		[Test]
		[Theory]
		[NonParallelizable]
		public void Filter(bool sen, bool order)
		{
			var arg = list[rand(0, 10)];
			var lim = rand(1, 10);
			var trimEnd = arg.Name.Substring(0, arg.Name.Length - 5);
			var filtered = db.Filter(trimEnd, lim, sen, order);
			Assert.GreaterOrEqual(lim, filtered.Count());
			Assert.IsTrue(filtered.Any(f => f.Id == arg.Id));
			foreach (var item in filtered)
				if (sen)
					Assert.IsTrue(item.Name.Contains(trimEnd));
				else
					Assert.IsTrue(item.Name.ToLower().Contains(trimEnd.ToLower()));
		}

		[Test]
		[NonParallelizable]
		public void FindOne()
		{
			var arg = list[rand(0, 10)];
			var res = db.FindOne(f => f.Name == arg.Name && f.Seasons == arg.Seasons);
			Assert.IsNotNull(res.Value);
			Assert.AreEqual(arg.Id, res.Value.Id);
		}
	}
}