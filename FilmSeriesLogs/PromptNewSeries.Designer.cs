
using System.Collections.Generic;

namespace FilmSeriesLogs
{
	partial class PromptNewSeries
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromptNewSeries));
			this.btnSubmit = new System.Windows.Forms.Button();
			this.txtboxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownSeasons = new System.Windows.Forms.NumericUpDown();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
			this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSubmit.FlatAppearance.BorderSize = 0;
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Location = new System.Drawing.Point(130, 123);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(64, 56);
			this.btnSubmit.TabIndex = 0;
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// txtboxName
			// 
			this.txtboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtboxName.Location = new System.Drawing.Point(74, 10);
			this.txtboxName.Name = "txtboxName";
			this.txtboxName.Size = new System.Drawing.Size(231, 27);
			this.txtboxName.TabIndex = 1;
			this.txtboxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxName_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label2.Location = new System.Drawing.Point(13, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Seasons:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label3.Location = new System.Drawing.Point(12, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Status:";
			// 
			// numericUpDownSeasons
			// 
			this.numericUpDownSeasons.Font = new System.Drawing.Font("Fira Code", 10F);
			this.numericUpDownSeasons.Location = new System.Drawing.Point(91, 89);
			this.numericUpDownSeasons.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownSeasons.Name = "numericUpDownSeasons";
			this.numericUpDownSeasons.Size = new System.Drawing.Size(82, 28);
			this.numericUpDownSeasons.TabIndex = 6;
			this.numericUpDownSeasons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxName_KeyDown);
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.BackColor = System.Drawing.SystemColors.Control;
			this.comboBoxStatus.Cursor = System.Windows.Forms.Cursors.Default;
			this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.comboBoxStatus.ForeColor = System.Drawing.SystemColors.WindowText;
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Items.AddRange(new object[] {
            "haven\'t watched",
            "watching",
            "watched"});
			this.comboBoxStatus.Location = new System.Drawing.Point(77, 51);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(128, 24);
			this.comboBoxStatus.TabIndex = 5;
			this.comboBoxStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxName_KeyDown);
			// 
			// PromptNewSeries
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 187);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.numericUpDownSeasons);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtboxName);
			this.Controls.Add(this.btnSubmit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "PromptNewSeries";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add new series";
			this.Shown += new System.EventHandler(this.PromptNewSeries_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PromptNewSeries_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.ComboBox comboBoxStatus;
		internal System.Windows.Forms.TextBox txtboxName;
		internal System.Windows.Forms.NumericUpDown numericUpDownSeasons;
	}
}