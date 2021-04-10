
namespace TvSeriesLogs
{
	partial class FavoritesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritesForm));
			this.ucDGV = new TvSeriesLogs.UserControlDGV();
			this.SuspendLayout();
			// 
			// userControlDGV
			// 
			this.ucDGV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucDGV.Location = new System.Drawing.Point(0, 0);
			this.ucDGV.Name = "userControlDGV";
			this.ucDGV.Size = new System.Drawing.Size(565, 317);
			this.ucDGV.TabIndex = 0;
			// 
			// FavoritesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 317);
			this.Controls.Add(this.ucDGV);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "FavoritesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Favorites";
			this.Shown += new System.EventHandler(this.FavoritesForm_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FavoritesForm_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private UserControlDGV ucDGV;
	}
}