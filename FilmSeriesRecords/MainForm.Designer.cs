
using System.Windows.Forms;

namespace FilmSeriesLogs
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripBtnAddSeries = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtnFilter = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtnFavorites = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnScrollTop = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtnScrollBottom = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnSettings = new System.Windows.Forms.ToolStripButton();
			this.lblLoading = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeriesList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.toolStrip.SuspendLayout();
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
			this.dgvSeriesList.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvSeriesList.GridColor = System.Drawing.Color.DodgerBlue;
			this.dgvSeriesList.Location = new System.Drawing.Point(0, 0);
			this.dgvSeriesList.Name = "dgvSeriesList";
			this.dgvSeriesList.ReadOnly = true;
			this.dgvSeriesList.RowHeadersVisible = false;
			this.dgvSeriesList.RowHeadersWidth = 51;
			this.dgvSeriesList.RowTemplate.Height = 24;
			this.dgvSeriesList.Size = new System.Drawing.Size(570, 317);
			this.dgvSeriesList.TabIndex = 2;
			this.dgvSeriesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSeriesList_CellContentClick);
			this.dgvSeriesList.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridSeriesList_SortCompare);
			this.dgvSeriesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSeriesList_KeyDown);
			// 
			// ColumnName
			// 
			this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Fira Code", 9F);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
			// ColumnSeasons
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11F);
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = "0";
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ColumnSeasons.DefaultCellStyle = dataGridViewCellStyle2;
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle3.NullValue = System.Windows.Forms.CheckState.Indeterminate;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnSeen.DefaultCellStyle = dataGridViewCellStyle3;
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
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.NullValue = null;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
			this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle4;
			this.ColumnDelete.FillWeight = 40F;
			this.ColumnDelete.HeaderText = "Del";
			this.ColumnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDelete.Image")));
			this.ColumnDelete.MinimumWidth = 40;
			this.ColumnDelete.Name = "ColumnDelete";
			this.ColumnDelete.ReadOnly = true;
			this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnDelete.ToolTipText = "Delete (shortcut: delete)";
			this.ColumnDelete.Width = 40;
			// 
			// ColumnEdit
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.PapayaWhip;
			dataGridViewCellStyle5.NullValue = null;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.NavajoWhite;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle5;
			this.ColumnEdit.FillWeight = 35F;
			this.ColumnEdit.HeaderText = "Edit";
			this.ColumnEdit.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEdit.Image")));
			this.ColumnEdit.MinimumWidth = 45;
			this.ColumnEdit.Name = "ColumnEdit";
			this.ColumnEdit.ReadOnly = true;
			this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnEdit.ToolTipText = "Edit (shortcut: e)";
			this.ColumnEdit.Width = 45;
			// 
			// ColumnInfo
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.NullValue = null;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
			this.ColumnInfo.DefaultCellStyle = dataGridViewCellStyle6;
			this.ColumnInfo.HeaderText = "Info";
			this.ColumnInfo.Image = ((System.Drawing.Image)(resources.GetObject("ColumnInfo.Image")));
			this.ColumnInfo.MinimumWidth = 40;
			this.ColumnInfo.Name = "ColumnInfo";
			this.ColumnInfo.ReadOnly = true;
			this.ColumnInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnInfo.ToolTipText = "Information (shortcut: i)";
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
			dataGridViewCellStyle7.Format = "N0";
			dataGridViewCellStyle7.NullValue = null;
			this.ColumnId.DefaultCellStyle = dataGridViewCellStyle7;
			this.ColumnId.HeaderText = "Id";
			this.ColumnId.MaxInputLength = 100;
			this.ColumnId.MinimumWidth = 6;
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.ReadOnly = true;
			this.ColumnId.Visible = false;
			this.ColumnId.Width = 125;
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.FillWeight = 40F;
			this.dataGridViewImageColumn1.HeaderText = "Delete";
			this.dataGridViewImageColumn1.MinimumWidth = 60;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewImageColumn1.ToolTipText = "Delete";
			this.dataGridViewImageColumn1.Width = 60;
			// 
			// dataGridViewImageColumn2
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.NullValue = null;
			dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewImageColumn2.FillWeight = 35F;
			this.dataGridViewImageColumn2.HeaderText = "Edit";
			this.dataGridViewImageColumn2.MinimumWidth = 45;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewImageColumn2.ToolTipText = "Edit";
			this.dataGridViewImageColumn2.Width = 45;
			// 
			// toolStrip
			// 
			this.toolStrip.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAddSeries,
            this.toolStripBtnFilter,
            this.toolStripBtnFavorites,
            this.toolStripSeparator2,
            this.toolStripBtnScrollTop,
            this.toolStripBtnScrollBottom,
            this.toolStripSeparator1,
            this.toolStripBtnSettings});
			this.toolStrip.Location = new System.Drawing.Point(0, 320);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(570, 39);
			this.toolStrip.TabIndex = 14;
			this.toolStrip.Text = "toolStrip1";
			// 
			// toolStripBtnAddSeries
			// 
			this.toolStripBtnAddSeries.BackColor = System.Drawing.Color.Transparent;
			this.toolStripBtnAddSeries.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnAddSeries.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripBtnAddSeries.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAddSeries.Image")));
			this.toolStripBtnAddSeries.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnAddSeries.Name = "toolStripBtnAddSeries";
			this.toolStripBtnAddSeries.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnAddSeries.ToolTipText = "Add new series (shortcut: ctrl + n)";
			this.toolStripBtnAddSeries.Click += new System.EventHandler(this.toolStripBtnAddSeries_Click);
			// 
			// toolStripBtnFilter
			// 
			this.toolStripBtnFilter.BackColor = System.Drawing.Color.Transparent;
			this.toolStripBtnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFilter.Image")));
			this.toolStripBtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnFilter.Name = "toolStripBtnFilter";
			this.toolStripBtnFilter.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnFilter.ToolTipText = "Search (shortcut: ctrl + f or s)";
			this.toolStripBtnFilter.Visible = false;
			this.toolStripBtnFilter.Click += new System.EventHandler(this.toolStripBtnFilter_Click);
			// 
			// toolStripBtnFavorites
			// 
			this.toolStripBtnFavorites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnFavorites.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnFavorites.Image")));
			this.toolStripBtnFavorites.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnFavorites.Name = "toolStripBtnFavorites";
			this.toolStripBtnFavorites.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnFavorites.ToolTipText = "Show favorites";
			this.toolStripBtnFavorites.Visible = false;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripBtnScrollTop
			// 
			this.toolStripBtnScrollTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnScrollTop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnScrollTop.Image")));
			this.toolStripBtnScrollTop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnScrollTop.Name = "toolStripBtnScrollTop";
			this.toolStripBtnScrollTop.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnScrollTop.ToolTipText = "Scroll to top";
			this.toolStripBtnScrollTop.Click += new System.EventHandler(this.toolStripBtnScrollTop_Click);
			// 
			// toolStripBtnScrollBottom
			// 
			this.toolStripBtnScrollBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnScrollBottom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnScrollBottom.Image")));
			this.toolStripBtnScrollBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnScrollBottom.Name = "toolStripBtnScrollBottom";
			this.toolStripBtnScrollBottom.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnScrollBottom.ToolTipText = "Scroll to bottom";
			this.toolStripBtnScrollBottom.Click += new System.EventHandler(this.toolStripBtnScrollBottom_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripBtnSettings
			// 
			this.toolStripBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSettings.Image")));
			this.toolStripBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnSettings.Name = "toolStripBtnSettings";
			this.toolStripBtnSettings.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnSettings.ToolTipText = "Settings (shortcut: ctrl + p)";
			this.toolStripBtnSettings.Visible = false;
			// 
			// lblLoading
			// 
			this.lblLoading.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lblLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLoading.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblLoading.ForeColor = System.Drawing.Color.Black;
			this.lblLoading.Location = new System.Drawing.Point(0, 25);
			this.lblLoading.Name = "lblLoading";
			this.lblLoading.Size = new System.Drawing.Size(570, 292);
			this.lblLoading.TabIndex = 15;
			this.lblLoading.Text = "Loading...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(570, 359);
			this.Controls.Add(this.lblLoading);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.dgvSeriesList);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Record of series";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dgvSeriesList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvSeriesList;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private ToolStrip toolStrip;
		private ToolStripButton toolStripBtnAddSeries;
		private ToolStripButton toolStripBtnFilter;
		private BindingSource bindingSource;
		private ToolStripButton toolStripBtnScrollTop;
		private ToolStripButton toolStripBtnScrollBottom;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripSeparator toolStripSeparator1;
		private Label lblLoading;
		private ToolStripButton toolStripBtnSettings;
		private DataGridViewTextBoxColumn ColumnName;
		private DataGridViewTextBoxColumn ColumnSeasons;
		private DataGridViewCheckBoxColumn ColumnSeen;
		private DataGridViewImageColumn ColumnDelete;
		private DataGridViewImageColumn ColumnEdit;
		private DataGridViewImageColumn ColumnInfo;
		private DataGridViewImageColumn ColumnNotes;
		private DataGridViewTextBoxColumn ColumnId;
		private ToolStripButton toolStripBtnFavorites;
	}
}

