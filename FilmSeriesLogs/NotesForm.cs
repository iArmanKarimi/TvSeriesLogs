using System.Windows.Forms;

namespace FilmSeriesLogs
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
