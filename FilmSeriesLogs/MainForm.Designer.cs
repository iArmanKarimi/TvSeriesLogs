
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.userControlDGV = new FilmSeriesLogs.UserControlDGV();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// ColumnName
			// 
			this.ColumnName.MinimumWidth = 6;
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.Width = 125;
			// 
			// ColumnSeasons
			// 
			this.ColumnSeasons.MinimumWidth = 6;
			this.ColumnSeasons.Name = "ColumnSeasons";
			this.ColumnSeasons.Width = 125;
			// 
			// ColumnSeen
			// 
			this.ColumnSeen.MinimumWidth = 6;
			this.ColumnSeen.Name = "ColumnSeen";
			this.ColumnSeen.Width = 125;
			// 
			// ColumnDelete
			// 
			this.ColumnDelete.MinimumWidth = 6;
			this.ColumnDelete.Name = "ColumnDelete";
			this.ColumnDelete.Width = 125;
			// 
			// ColumnEdit
			// 
			this.ColumnEdit.MinimumWidth = 6;
			this.ColumnEdit.Name = "ColumnEdit";
			this.ColumnEdit.Width = 125;
			// 
			// ColumnInfo
			// 
			this.ColumnInfo.MinimumWidth = 6;
			this.ColumnInfo.Name = "ColumnInfo";
			this.ColumnInfo.Width = 125;
			// 
			// ColumnNotes
			// 
			this.ColumnNotes.MinimumWidth = 6;
			this.ColumnNotes.Name = "ColumnNotes";
			this.ColumnNotes.Width = 125;
			// 
			// ColumnId
			// 
			this.ColumnId.MinimumWidth = 6;
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.Width = 125;
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.MinimumWidth = 6;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 125;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.MinimumWidth = 6;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Width = 125;
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
			this.toolStrip.Location = new System.Drawing.Point(0, 286);
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
			// userControlDGV
			// 
			this.userControlDGV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlDGV.Location = new System.Drawing.Point(0, 0);
			this.userControlDGV.Name = "userControlDGV";
			this.userControlDGV.Size = new System.Drawing.Size(570, 286);
			this.userControlDGV.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(570, 325);
			this.Controls.Add(this.userControlDGV);
			this.Controls.Add(this.toolStrip);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(50, 50);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Film series logs";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
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
		private UserControlDGV userControlDGV;
	}
}

