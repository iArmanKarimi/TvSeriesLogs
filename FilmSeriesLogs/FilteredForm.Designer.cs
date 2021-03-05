
namespace FilmSeriesLogs
{
	partial class FilteredForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteredForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvSeriesList = new System.Windows.Forms.DataGridView();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSeasons = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSeen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnInfo = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnNotes = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvSeriesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSeriesList
			// 
			this.dgvSeriesList.AllowUserToAddRows = false;
			this.dgvSeriesList.AllowUserToDeleteRows = false;
			this.dgvSeriesList.AllowUserToOrderColumns = true;
			this.dgvSeriesList.AutoGenerateColumns = false;
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
			this.dgvSeriesList.DataSource = this.bindingSource;
			this.dgvSeriesList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSeriesList.GridColor = System.Drawing.Color.DodgerBlue;
			this.dgvSeriesList.Location = new System.Drawing.Point(0, 0);
			this.dgvSeriesList.Name = "dgvSeriesList";
			this.dgvSeriesList.ReadOnly = true;
			this.dgvSeriesList.RowHeadersVisible = false;
			this.dgvSeriesList.RowHeadersWidth = 51;
			this.dgvSeriesList.RowTemplate.Height = 24;
			this.dgvSeriesList.Size = new System.Drawing.Size(488, 271);
			this.dgvSeriesList.TabIndex = 3;
			// 
			// ColumnName
			// 
			this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Fira Code SemiBold", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnName.DefaultCellStyle = dataGridViewCellStyle8;
			this.ColumnName.FillWeight = 91.57754F;
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.MinimumWidth = 6;
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.ToolTipText = "Name of the series";
			// 
			// ColumnSeasons
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 11F);
			dataGridViewCellStyle9.Format = "N0";
			dataGridViewCellStyle9.NullValue = "0";
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ColumnSeasons.DefaultCellStyle = dataGridViewCellStyle9;
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
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle10.NullValue = System.Windows.Forms.CheckState.Indeterminate;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnSeen.DefaultCellStyle = dataGridViewCellStyle10;
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
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle11.NullValue = null;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MistyRose;
			this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle11;
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
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.PapayaWhip;
			dataGridViewCellStyle12.NullValue = null;
			dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.NavajoWhite;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle12;
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
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle13.NullValue = null;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.ColumnInfo.DefaultCellStyle = dataGridViewCellStyle13;
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
			dataGridViewCellStyle14.Format = "N0";
			dataGridViewCellStyle14.NullValue = null;
			this.ColumnId.DefaultCellStyle = dataGridViewCellStyle14;
			this.ColumnId.HeaderText = "Id";
			this.ColumnId.MaxInputLength = 100;
			this.ColumnId.MinimumWidth = 6;
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.ReadOnly = true;
			this.ColumnId.Visible = false;
			this.ColumnId.Width = 125;
			// 
			// FilteredForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 271);
			this.Controls.Add(this.dgvSeriesList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FilteredForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search result";
			this.Shown += new System.EventHandler(this.FilteredForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dgvSeriesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
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
		private System.Windows.Forms.BindingSource bindingSource;
	}
}