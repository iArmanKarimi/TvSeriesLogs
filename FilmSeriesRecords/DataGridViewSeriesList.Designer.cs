
namespace FilmSeriesLogs
{
	partial class DataGridViewSeriesList
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewSeriesList));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvSeriesList = new System.Windows.Forms.DataGridView();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSeasons = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSeen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnInfo = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnNotes = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeriesList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSeriesList
			// 
			this.dgvSeriesList.AllowUserToAddRows = false;
			this.dgvSeriesList.AllowUserToDeleteRows = false;
			this.dgvSeriesList.AllowUserToOrderColumns = true;
			this.dgvSeriesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSeriesList.BackgroundColor = System.Drawing.Color.Wheat;
			this.dgvSeriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeriesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSeasons,
            this.ColumnSeen,
            this.ColumnDelete,
            this.ColumnEdit,
            this.ColumnInfo,
            this.ColumnNotes,
            this.ColumnId});
			this.dgvSeriesList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSeriesList.GridColor = System.Drawing.Color.DodgerBlue;
			this.dgvSeriesList.Location = new System.Drawing.Point(0, 0);
			this.dgvSeriesList.Name = "dgvSeriesList";
			this.dgvSeriesList.ReadOnly = true;
			this.dgvSeriesList.RowHeadersVisible = false;
			this.dgvSeriesList.RowHeadersWidth = 51;
			this.dgvSeriesList.RowTemplate.Height = 24;
			this.dgvSeriesList.Size = new System.Drawing.Size(528, 280);
			this.dgvSeriesList.TabIndex = 3;
			// 
			// ColumnName
			// 
			this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.Azure;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Fira Code SemiBold", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnName.DefaultCellStyle = dataGridViewCellStyle15;
			this.ColumnName.FillWeight = 91.57754F;
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.MinimumWidth = 6;
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.ToolTipText = "Name of the series";
			// 
			// ColumnSeasons
			// 
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 11F);
			dataGridViewCellStyle16.Format = "N0";
			dataGridViewCellStyle16.NullValue = "0";
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ColumnSeasons.DefaultCellStyle = dataGridViewCellStyle16;
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
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle17.NullValue = System.Windows.Forms.CheckState.Indeterminate;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnSeen.DefaultCellStyle = dataGridViewCellStyle17;
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
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle18.NullValue = null;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.MistyRose;
			this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle18;
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
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.PapayaWhip;
			dataGridViewCellStyle19.NullValue = null;
			dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.NavajoWhite;
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle19;
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
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle20.NullValue = null;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.ColumnInfo.DefaultCellStyle = dataGridViewCellStyle20;
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
			dataGridViewCellStyle21.Format = "N0";
			dataGridViewCellStyle21.NullValue = null;
			this.ColumnId.DefaultCellStyle = dataGridViewCellStyle21;
			this.ColumnId.HeaderText = "Id";
			this.ColumnId.MaxInputLength = 100;
			this.ColumnId.MinimumWidth = 6;
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.ReadOnly = true;
			this.ColumnId.Visible = false;
			this.ColumnId.Width = 125;
			// 
			// DataGridViewSeriesList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvSeriesList);
			this.Name = "DataGridViewSeriesList";
			this.Size = new System.Drawing.Size(528, 280);
			((System.ComponentModel.ISupportInitialize)(this.dgvSeriesList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSeriesList;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeasons;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSeen;
		private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
		private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
		private System.Windows.Forms.DataGridViewImageColumn ColumnInfo;
		private System.Windows.Forms.DataGridViewImageColumn ColumnNotes;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
	}
}
