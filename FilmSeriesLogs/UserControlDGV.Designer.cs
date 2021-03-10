
namespace FilmSeriesLogs
{
	partial class UserControlDGV
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDGV));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSeasons = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSeen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnInfo = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnNotes = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.AllowUserToOrderColumns = true;
			this.dgv.AutoGenerateColumns = false;
			this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgv.BackgroundColor = System.Drawing.Color.Wheat;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSeasons,
            this.ColumnSeen,
            this.ColumnDelete,
            this.ColumnEdit,
            this.ColumnInfo,
            this.ColumnNotes,
            this.ColumnId});
			this.dgv.DataSource = this.bindingSource;
			this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv.GridColor = System.Drawing.Color.DodgerBlue;
			this.dgv.Location = new System.Drawing.Point(0, 0);
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.RowHeadersVisible = false;
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(528, 280);
			this.dgv.TabIndex = 3;
			this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSeriesList_CellContentClick);
			this.dgv.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridSeriesList_SortCompare);
			this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSeriesList_KeyDown);
			// 
			// ColumnName
			// 
			this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle36.BackColor = System.Drawing.Color.Azure;
			dataGridViewCellStyle36.Font = new System.Drawing.Font("Fira Code SemiBold", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnName.DefaultCellStyle = dataGridViewCellStyle36;
			this.ColumnName.FillWeight = 91.57754F;
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.MinimumWidth = 6;
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.ToolTipText = "Name of the series";
			// 
			// ColumnSeasons
			// 
			dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle37.Font = new System.Drawing.Font("Consolas", 11F);
			dataGridViewCellStyle37.Format = "N0";
			dataGridViewCellStyle37.NullValue = "0";
			dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ColumnSeasons.DefaultCellStyle = dataGridViewCellStyle37;
			this.ColumnSeasons.FillWeight = 30F;
			this.ColumnSeasons.HeaderText = "Seasons";
			this.ColumnSeasons.MaxInputLength = 5;
			this.ColumnSeasons.MinimumWidth = 67;
			this.ColumnSeasons.Name = "ColumnSeasons";
			this.ColumnSeasons.ReadOnly = true;
			this.ColumnSeasons.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnSeasons.ToolTipText = "Number of seasons";
			this.ColumnSeasons.Width = 67;
			// 
			// ColumnSeen
			// 
			dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle38.NullValue = System.Windows.Forms.CheckState.Indeterminate;
			dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnSeen.DefaultCellStyle = dataGridViewCellStyle38;
			this.ColumnSeen.FalseValue = "0";
			this.ColumnSeen.FillWeight = 35F;
			this.ColumnSeen.HeaderText = "Seen";
			this.ColumnSeen.IndeterminateValue = "1";
			this.ColumnSeen.MinimumWidth = 50;
			this.ColumnSeen.Name = "ColumnSeen";
			this.ColumnSeen.ReadOnly = true;
			this.ColumnSeen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnSeen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColumnSeen.ThreeState = true;
			this.ColumnSeen.ToolTipText = "Have I seen this series?";
			this.ColumnSeen.TrueValue = "2";
			this.ColumnSeen.Width = 50;
			// 
			// ColumnDelete
			// 
			dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle39.NullValue = null;
			dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.MistyRose;
			this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle39;
			this.ColumnDelete.FillWeight = 40F;
			this.ColumnDelete.HeaderText = "Del";
			this.ColumnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDelete.Image")));
			this.ColumnDelete.MinimumWidth = 40;
			this.ColumnDelete.Name = "ColumnDelete";
			this.ColumnDelete.ReadOnly = true;
			this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnDelete.ToolTipText = "Delete";
			this.ColumnDelete.Width = 40;
			// 
			// ColumnEdit
			// 
			dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle40.BackColor = System.Drawing.Color.PapayaWhip;
			dataGridViewCellStyle40.NullValue = null;
			dataGridViewCellStyle40.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.NavajoWhite;
			dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle40;
			this.ColumnEdit.FillWeight = 35F;
			this.ColumnEdit.HeaderText = "Edit";
			this.ColumnEdit.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEdit.Image")));
			this.ColumnEdit.MinimumWidth = 45;
			this.ColumnEdit.Name = "ColumnEdit";
			this.ColumnEdit.ReadOnly = true;
			this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnEdit.ToolTipText = "Edit";
			this.ColumnEdit.Width = 45;
			// 
			// ColumnInfo
			// 
			dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle41.NullValue = null;
			dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.ColumnInfo.DefaultCellStyle = dataGridViewCellStyle41;
			this.ColumnInfo.HeaderText = "Info";
			this.ColumnInfo.Image = ((System.Drawing.Image)(resources.GetObject("ColumnInfo.Image")));
			this.ColumnInfo.MinimumWidth = 40;
			this.ColumnInfo.Name = "ColumnInfo";
			this.ColumnInfo.ReadOnly = true;
			this.ColumnInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnInfo.ToolTipText = "Information about series";
			this.ColumnInfo.Width = 40;
			// 
			// ColumnNotes
			// 
			this.ColumnNotes.HeaderText = "Notes";
			this.ColumnNotes.Image = ((System.Drawing.Image)(resources.GetObject("ColumnNotes.Image")));
			this.ColumnNotes.MinimumWidth = 50;
			this.ColumnNotes.Name = "ColumnNotes";
			this.ColumnNotes.ReadOnly = true;
			this.ColumnNotes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnNotes.Visible = false;
			this.ColumnNotes.Width = 50;
			// 
			// ColumnId
			// 
			dataGridViewCellStyle42.Format = "N0";
			dataGridViewCellStyle42.NullValue = null;
			this.ColumnId.DefaultCellStyle = dataGridViewCellStyle42;
			this.ColumnId.HeaderText = "Id";
			this.ColumnId.MaxInputLength = 100;
			this.ColumnId.MinimumWidth = 6;
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.ReadOnly = true;
			this.ColumnId.Visible = false;
			this.ColumnId.Width = 125;
			// 
			// UserControlDGV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgv);
			this.Name = "UserControlDGV";
			this.Size = new System.Drawing.Size(528, 280);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeasons;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSeen;
		private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
		private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
		private System.Windows.Forms.DataGridViewImageColumn ColumnInfo;
		private System.Windows.Forms.DataGridViewImageColumn ColumnNotes;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
		private System.Windows.Forms.BindingSource bindingSource;
	}
}
