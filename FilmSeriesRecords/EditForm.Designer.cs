
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownSeasons = new System.Windows.Forms.NumericUpDown();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.groupBoxSchedule = new System.Windows.Forms.GroupBox();
			this.checkBoxInterruptionTime = new System.Windows.Forms.CheckBox();
			this.checkBoxStartsAt = new System.Windows.Forms.CheckBox();
			this.dateTimePickerShowStartsAtTime = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerShowStartsAtDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerInterruptionTime = new System.Windows.Forms.DateTimePicker();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).BeginInit();
			this.groupBoxSchedule.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(67, 14);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(206, 22);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 49);
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
			this.comboBoxStatus.Location = new System.Drawing.Point(77, 47);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(127, 24);
			this.comboBoxStatus.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Seasons:";
			// 
			// numericUpDownSeasons
			// 
			this.numericUpDownSeasons.Font = new System.Drawing.Font("Fira Code", 9F);
			this.numericUpDownSeasons.Location = new System.Drawing.Point(85, 82);
			this.numericUpDownSeasons.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownSeasons.Name = "numericUpDownSeasons";
			this.numericUpDownSeasons.Size = new System.Drawing.Size(82, 26);
			this.numericUpDownSeasons.TabIndex = 3;
			// 
			// btnSubmit
			// 
			this.btnSubmit.FlatAppearance.BorderSize = 0;
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
			this.btnSubmit.Location = new System.Drawing.Point(168, 346);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(63, 52);
			this.btnSubmit.TabIndex = 11;
			this.btnSubmit.UseVisualStyleBackColor = true;
			// 
			// groupBoxSchedule
			// 
			this.groupBoxSchedule.Controls.Add(this.checkBoxInterruptionTime);
			this.groupBoxSchedule.Controls.Add(this.checkBoxStartsAt);
			this.groupBoxSchedule.Controls.Add(this.dateTimePickerShowStartsAtTime);
			this.groupBoxSchedule.Controls.Add(this.dateTimePickerShowStartsAtDate);
			this.groupBoxSchedule.Controls.Add(this.dateTimePickerInterruptionTime);
			this.groupBoxSchedule.Controls.Add(this.numericUpDown2);
			this.groupBoxSchedule.Controls.Add(this.numericUpDown1);
			this.groupBoxSchedule.Controls.Add(this.label7);
			this.groupBoxSchedule.Controls.Add(this.label6);
			this.groupBoxSchedule.Controls.Add(this.label5);
			this.groupBoxSchedule.Controls.Add(this.label4);
			this.groupBoxSchedule.Location = new System.Drawing.Point(12, 123);
			this.groupBoxSchedule.Name = "groupBoxSchedule";
			this.groupBoxSchedule.Size = new System.Drawing.Size(371, 217);
			this.groupBoxSchedule.TabIndex = 12;
			this.groupBoxSchedule.TabStop = false;
			this.groupBoxSchedule.Text = "Next show schedule";
			// 
			// checkBoxInterruptionTime
			// 
			this.checkBoxInterruptionTime.AutoSize = true;
			this.checkBoxInterruptionTime.Location = new System.Drawing.Point(229, 109);
			this.checkBoxInterruptionTime.Name = "checkBoxInterruptionTime";
			this.checkBoxInterruptionTime.Size = new System.Drawing.Size(18, 17);
			this.checkBoxInterruptionTime.TabIndex = 6;
			this.checkBoxInterruptionTime.UseVisualStyleBackColor = true;
			// 
			// checkBoxStartsAt
			// 
			this.checkBoxStartsAt.AutoSize = true;
			this.checkBoxStartsAt.Location = new System.Drawing.Point(329, 149);
			this.checkBoxStartsAt.Name = "checkBoxStartsAt";
			this.checkBoxStartsAt.Size = new System.Drawing.Size(18, 17);
			this.checkBoxStartsAt.TabIndex = 8;
			this.checkBoxStartsAt.UseVisualStyleBackColor = true;
			// 
			// dateTimePickerShowStartsAtTime
			// 
			this.dateTimePickerShowStartsAtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerShowStartsAtTime.Location = new System.Drawing.Point(69, 175);
			this.dateTimePickerShowStartsAtTime.Name = "dateTimePickerShowStartsAtTime";
			this.dateTimePickerShowStartsAtTime.ShowUpDown = true;
			this.dateTimePickerShowStartsAtTime.Size = new System.Drawing.Size(139, 22);
			this.dateTimePickerShowStartsAtTime.TabIndex = 10;
			// 
			// dateTimePickerShowStartsAtDate
			// 
			this.dateTimePickerShowStartsAtDate.Location = new System.Drawing.Point(69, 147);
			this.dateTimePickerShowStartsAtDate.Name = "dateTimePickerShowStartsAtDate";
			this.dateTimePickerShowStartsAtDate.Size = new System.Drawing.Size(254, 22);
			this.dateTimePickerShowStartsAtDate.TabIndex = 9;
			// 
			// dateTimePickerInterruptionTime
			// 
			this.dateTimePickerInterruptionTime.CustomFormat = "HH:mm:ss";
			this.dateTimePickerInterruptionTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerInterruptionTime.Location = new System.Drawing.Point(118, 107);
			this.dateTimePickerInterruptionTime.Name = "dateTimePickerInterruptionTime";
			this.dateTimePickerInterruptionTime.ShowUpDown = true;
			this.dateTimePickerInterruptionTime.Size = new System.Drawing.Size(105, 22);
			this.dateTimePickerInterruptionTime.TabIndex = 7;
			this.dateTimePickerInterruptionTime.Value = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Font = new System.Drawing.Font("Fira Code", 9F);
			this.numericUpDown2.Location = new System.Drawing.Point(72, 58);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(82, 26);
			this.numericUpDown2.TabIndex = 5;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Fira Code", 9F);
			this.numericUpDown1.Location = new System.Drawing.Point(72, 26);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(82, 26);
			this.numericUpDown1.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 149);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 17);
			this.label7.TabIndex = 4;
			this.label7.Text = "Starts at:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 107);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(114, 17);
			this.label6.TabIndex = 3;
			this.label6.Text = "Interruption time:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "Episode:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Season:";
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 407);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBoxSchedule);
			this.Controls.Add(this.numericUpDownSeasons);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "EditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).EndInit();
			this.groupBoxSchedule.ResumeLayout(false);
			this.groupBoxSchedule.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.GroupBox groupBoxSchedule;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		internal System.Windows.Forms.NumericUpDown numericUpDown1;
		internal System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.DateTimePicker dateTimePickerInterruptionTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerShowStartsAtDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerShowStartsAtTime;
		private System.Windows.Forms.CheckBox checkBoxStartsAt;
		private System.Windows.Forms.CheckBox checkBoxInterruptionTime;
	}
}