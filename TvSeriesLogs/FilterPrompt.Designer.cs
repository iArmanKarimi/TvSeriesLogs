
namespace TvSeriesLogs
{
	partial class FilterPrompt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterPrompt));
			this.btnFilterSubmit = new System.Windows.Forms.Button();
			this.checkBoxFilterCaseSensitive = new System.Windows.Forms.CheckBox();
			this.numericUpDownFilterLimit = new System.Windows.Forms.NumericUpDown();
			this.txtboxFilter = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterLimit)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFilterSubmit
			// 
			this.btnFilterSubmit.BackColor = System.Drawing.Color.Transparent;
			this.btnFilterSubmit.FlatAppearance.BorderSize = 0;
			this.btnFilterSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFilterSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterSubmit.Image")));
			this.btnFilterSubmit.Location = new System.Drawing.Point(152, 72);
			this.btnFilterSubmit.Name = "btnFilterSubmit";
			this.btnFilterSubmit.Size = new System.Drawing.Size(52, 52);
			this.btnFilterSubmit.TabIndex = 4;
			this.btnFilterSubmit.UseVisualStyleBackColor = false;
			this.btnFilterSubmit.Click += new System.EventHandler(this.btnFilterSubmit_Click);
			// 
			// checkBoxFilterCaseSensitive
			// 
			this.checkBoxFilterCaseSensitive.AutoSize = true;
			this.checkBoxFilterCaseSensitive.Location = new System.Drawing.Point(70, 45);
			this.checkBoxFilterCaseSensitive.Name = "checkBoxFilterCaseSensitive";
			this.checkBoxFilterCaseSensitive.Size = new System.Drawing.Size(120, 21);
			this.checkBoxFilterCaseSensitive.TabIndex = 2;
			this.checkBoxFilterCaseSensitive.Text = "case-sensitive";
			this.checkBoxFilterCaseSensitive.UseVisualStyleBackColor = true;
			// 
			// numericUpDownFilterLimit
			// 
			this.numericUpDownFilterLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownFilterLimit.Location = new System.Drawing.Point(70, 88);
			this.numericUpDownFilterLimit.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
			this.numericUpDownFilterLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownFilterLimit.Name = "numericUpDownFilterLimit";
			this.numericUpDownFilterLimit.Size = new System.Drawing.Size(76, 22);
			this.numericUpDownFilterLimit.TabIndex = 3;
			this.numericUpDownFilterLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDownFilterLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxFilter_KeyDown);
			// 
			// txtboxFilter
			// 
			this.txtboxFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtboxFilter.Location = new System.Drawing.Point(70, 12);
			this.txtboxFilter.Name = "txtboxFilter";
			this.txtboxFilter.Size = new System.Drawing.Size(134, 27);
			this.txtboxFilter.TabIndex = 1;
			this.txtboxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxFilter_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.Location = new System.Drawing.Point(19, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "Limit:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.Location = new System.Drawing.Point(12, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Name:";
			// 
			// FilterPrompt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(218, 129);
			this.Controls.Add(this.btnFilterSubmit);
			this.Controls.Add(this.checkBoxFilterCaseSensitive);
			this.Controls.Add(this.numericUpDownFilterLimit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtboxFilter);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "FilterPrompt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Search";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterLimit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnFilterSubmit;
		private System.Windows.Forms.CheckBox checkBoxFilterCaseSensitive;
		private System.Windows.Forms.NumericUpDown numericUpDownFilterLimit;
		private System.Windows.Forms.TextBox txtboxFilter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}