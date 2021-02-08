using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilmSeriesRecords
{
	public partial class EditForm : Form
	{
		public readonly int Id;
		public string SeriesName { get; private set; }
		public EditForm(int Id)
		{
			this.Id = Id;
			InitializeComponent();
		}
	}
}
