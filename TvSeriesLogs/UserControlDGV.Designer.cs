
namespace TvSeriesLogs
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDGV));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSeason = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnEpisode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSeen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColumnInfo = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnNotes = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ColumnSeason,
            this.ColumnEpisode,
            this.ColumnSeen,
            this.ColumnInfo,
            this.ColumnEdit,
            this.ColumnDelete,
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnName.DefaultCellStyle = dataGridViewCellStyle1;
			this.ColumnName.FillWeight = 91.57754F;
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.MinimumWidth = 6;
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.ToolTipText = "Name of the series";
			// 
			// ColumnSeason
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnSeason.DefaultCellStyle = dataGridViewCellStyle2;
			this.ColumnSeason.HeaderText = "Season";
			this.ColumnSeason.MinimumWidth = 6;
			this.ColumnSeason.Name = "ColumnSeason";
			this.ColumnSeason.ReadOnly = true;
			this.ColumnSeason.ToolTipText = "Current season";
			this.ColumnSeason.Width = 60;
			// 
			// ColumnEpisode
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 11F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnEpisode.DefaultCellStyle = dataGridViewCellStyle3;
			this.ColumnEpisode.HeaderText = "Episode";
			this.ColumnEpisode.MinimumWidth = 6;
			this.ColumnEpisode.Name = "ColumnEpisode";
			this.ColumnEpisode.ReadOnly = true;
			this.ColumnEpisode.ToolTipText = "Current episode";
			this.ColumnEpisode.Width = 63;
			// 
			// ColumnSeen
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.NullValue = System.Windows.Forms.CheckState.Indeterminate;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnSeen.DefaultCellStyle = dataGridViewCellStyle4;
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
			// ColumnInfo
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.NullValue = null;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.ColumnInfo.DefaultCellStyle = dataGridViewCellStyle5;
			this.ColumnInfo.HeaderText = "Info";
			this.ColumnInfo.Image = ((System.Drawing.Image)(resources.GetObject("ColumnInfo.Image")));
			this.ColumnInfo.MinimumWidth = 40;
			this.ColumnInfo.Name = "ColumnInfo";
			this.ColumnInfo.ReadOnly = true;
			this.ColumnInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnInfo.ToolTipText = "Information about series";
			this.ColumnInfo.Width = 40;
			// 
			// ColumnEdit
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.PapayaWhip;
			dataGridViewCellStyle6.NullValue = null;
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.NavajoWhite;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle6;
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
			// ColumnDelete
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle7.NullValue = null;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MistyRose;
			this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle7;
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
			dataGridViewCellStyle8.Format = "N0";
			dataGridViewCellStyle8.NullValue = null;
			this.ColumnId.DefaultCellStyle = dataGridViewCellStyle8;
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
		private System.Windows.Forms.BindingSource bindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeason;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEpisode;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSeen;
		private System.Windows.Forms.DataGridViewImageColumn ColumnInfo;
		private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
		private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
		private System.Windows.Forms.DataGridViewImageColumn ColumnNotes;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
	}
}
