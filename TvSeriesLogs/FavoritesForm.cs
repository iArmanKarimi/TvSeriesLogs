using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TvSeriesLogsDb;

namespace TvSeriesLogs
{
	public partial class FavoritesForm : Form
	{
		private readonly SeriesDb db;
		private readonly Func<IEnumerable<Series>> getResult;

		public FavoritesForm(SeriesDb db, Func<IEnumerable<Series>> getResult)
		{
			this.db = db;
			this.getResult = getResult;
			InitializeComponent();
		}

		private void FavoritesForm_Shown(object sender, EventArgs e)
		{
			ucDGV.OnFormShown(db);
			ucDGV.BindData(getResult);
		}
		private void FavoritesForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}
	}
}
