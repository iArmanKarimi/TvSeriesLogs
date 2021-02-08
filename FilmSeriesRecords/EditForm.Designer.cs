
namespace FilmSeriesRecords
{
	partial class EditForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownSeasons = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(68, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(206, 22);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Status:";
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
			this.comboBoxStatus.Location = new System.Drawing.Point(70, 51);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(128, 24);
			this.comboBoxStatus.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Seasons:";
			// 
			// numericUpDownSeasons
			// 
			this.numericUpDownSeasons.Font = new System.Drawing.Font("Fira Code", 9F);
			this.numericUpDownSeasons.Location = new System.Drawing.Point(86, 86);
			this.numericUpDownSeasons.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownSeasons.Name = "numericUpDownSeasons";
			this.numericUpDownSeasons.Size = new System.Drawing.Size(82, 26);
			this.numericUpDownSeasons.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(189, 339);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 54);
			this.button1.TabIndex = 11;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 405);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.numericUpDownSeasons);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "EditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.NumericUpDown numericUpDownSeasons;
		private System.Windows.Forms.Button button1;
	}
}