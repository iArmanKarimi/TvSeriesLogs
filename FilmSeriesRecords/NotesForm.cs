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
	public partial class NotesForm : Form
	{
		public readonly int Id;
		public NotesForm(int Id)
		{
			this.Id = Id;
			InitializeComponent();
		}
	}
}
