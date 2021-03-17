
namespace TvSeriesLogs
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtboxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownSeasons = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBoxSchedule = new System.Windows.Forms.GroupBox();
			this.btnResetScheduleStartsAt = new System.Windows.Forms.Button();
			this.btnResetScheduleInterruptionTime = new System.Windows.Forms.Button();
			this.dateTimePickerShowStartsAtTime = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerShowStartsAtDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerInterruptionTime = new System.Windows.Forms.DateTimePicker();
			this.numericUpDownScheduleEpisode = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownScheduleSeasons = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.timerAnimateSavedNotification = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numericUpDownTimesWatched = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.richTextBoxGenres = new System.Windows.Forms.RichTextBox();
			this.btnFavorite = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).BeginInit();
			this.groupBoxSchedule.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScheduleEpisode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScheduleSeasons)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimesWatched)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(130, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// txtboxName
			// 
			this.txtboxName.Location = new System.Drawing.Point(180, 14);
			this.txtboxName.Name = "txtboxName";
			this.txtboxName.Size = new System.Drawing.Size(307, 22);
			this.txtboxName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(130, 51);
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
			this.comboBoxStatus.Location = new System.Drawing.Point(180, 50);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(127, 24);
			this.comboBoxStatus.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(335, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Seasons:";
			// 
			// numericUpDownSeasons
			// 
			this.numericUpDownSeasons.Font = new System.Drawing.Font("Fira Code", 9F);
			this.numericUpDownSeasons.Location = new System.Drawing.Point(404, 49);
			this.numericUpDownSeasons.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownSeasons.Name = "numericUpDownSeasons";
			this.numericUpDownSeasons.Size = new System.Drawing.Size(82, 26);
			this.numericUpDownSeasons.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.Location = new System.Drawing.Point(295, 313);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(63, 52);
			this.btnSave.TabIndex = 11;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBoxSchedule
			// 
			this.groupBoxSchedule.Controls.Add(this.btnResetScheduleStartsAt);
			this.groupBoxSchedule.Controls.Add(this.btnResetScheduleInterruptionTime);
			this.groupBoxSchedule.Controls.Add(this.dateTimePickerShowStartsAtTime);
			this.groupBoxSchedule.Controls.Add(this.dateTimePickerShowStartsAtDate);
			this.groupBoxSchedule.Controls.Add(this.dateTimePickerInterruptionTime);
			this.groupBoxSchedule.Controls.Add(this.numericUpDownScheduleEpisode);
			this.groupBoxSchedule.Controls.Add(this.numericUpDownScheduleSeasons);
			this.groupBoxSchedule.Controls.Add(this.label7);
			this.groupBoxSchedule.Controls.Add(this.label6);
			this.groupBoxSchedule.Controls.Add(this.label5);
			this.groupBoxSchedule.Controls.Add(this.label4);
			this.groupBoxSchedule.Location = new System.Drawing.Point(12, 90);
			this.groupBoxSchedule.Name = "groupBoxSchedule";
			this.groupBoxSchedule.Size = new System.Drawing.Size(336, 217);
			this.groupBoxSchedule.TabIndex = 12;
			this.groupBoxSchedule.TabStop = false;
			this.groupBoxSchedule.Text = "Next show schedule";
			// 
			// btnResetScheduleStartsAt
			// 
			this.btnResetScheduleStartsAt.BackColor = System.Drawing.Color.Transparent;
			this.btnResetScheduleStartsAt.FlatAppearance.BorderSize = 0;
			this.btnResetScheduleStartsAt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResetScheduleStartsAt.Image = ((System.Drawing.Image)(resources.GetObject("btnResetScheduleStartsAt.Image")));
			this.btnResetScheduleStartsAt.Location = new System.Drawing.Point(214, 174);
			this.btnResetScheduleStartsAt.Name = "btnResetScheduleStartsAt";
			this.btnResetScheduleStartsAt.Size = new System.Drawing.Size(42, 23);
			this.btnResetScheduleStartsAt.TabIndex = 13;
			this.btnResetScheduleStartsAt.UseVisualStyleBackColor = false;
			this.btnResetScheduleStartsAt.Click += new System.EventHandler(this.btnResetScheduleStartsAt_Click);
			// 
			// btnResetScheduleInterruptionTime
			// 
			this.btnResetScheduleInterruptionTime.BackColor = System.Drawing.Color.Transparent;
			this.btnResetScheduleInterruptionTime.FlatAppearance.BorderSize = 0;
			this.btnResetScheduleInterruptionTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResetScheduleInterruptionTime.Image = ((System.Drawing.Image)(resources.GetObject("btnResetScheduleInterruptionTime.Image")));
			this.btnResetScheduleInterruptionTime.Location = new System.Drawing.Point(229, 107);
			this.btnResetScheduleInterruptionTime.Name = "btnResetScheduleInterruptionTime";
			this.btnResetScheduleInterruptionTime.Size = new System.Drawing.Size(42, 23);
			this.btnResetScheduleInterruptionTime.TabIndex = 11;
			this.btnResetScheduleInterruptionTime.UseVisualStyleBackColor = false;
			this.btnResetScheduleInterruptionTime.Click += new System.EventHandler(this.btnResetScheduleInterruptionTime_Click);
			// 
			// dateTimePickerShowStartsAtTime
			// 
			this.dateTimePickerShowStartsAtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerShowStartsAtTime.Location = new System.Drawing.Point(69, 175);
			this.dateTimePickerShowStartsAtTime.Name = "dateTimePickerShowStartsAtTime";
			this.dateTimePickerShowStartsAtTime.ShowUpDown = true;
			this.dateTimePickerShowStartsAtTime.Size = new System.Drawing.Size(139, 22);
			this.dateTimePickerShowStartsAtTime.TabIndex = 10;
			this.dateTimePickerShowStartsAtTime.Value = new System.DateTime(2021, 2, 10, 0, 0, 0, 0);
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
			// numericUpDownScheduleEpisode
			// 
			this.numericUpDownScheduleEpisode.Font = new System.Drawing.Font("Fira Code", 9F);
			this.numericUpDownScheduleEpisode.Location = new System.Drawing.Point(72, 58);
			this.numericUpDownScheduleEpisode.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownScheduleEpisode.Name = "numericUpDownScheduleEpisode";
			this.numericUpDownScheduleEpisode.Size = new System.Drawing.Size(82, 26);
			this.numericUpDownScheduleEpisode.TabIndex = 5;
			// 
			// numericUpDownScheduleSeasons
			// 
			this.numericUpDownScheduleSeasons.Font = new System.Drawing.Font("Fira Code", 9F);
			this.numericUpDownScheduleSeasons.Location = new System.Drawing.Point(72, 26);
			this.numericUpDownScheduleSeasons.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownScheduleSeasons.Name = "numericUpDownScheduleSeasons";
			this.numericUpDownScheduleSeasons.Size = new System.Drawing.Size(82, 26);
			this.numericUpDownScheduleSeasons.TabIndex = 4;
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
			// timerAnimateSavedNotification
			// 
			this.timerAnimateSavedNotification.Interval = 1000;
			this.timerAnimateSavedNotification.Tick += new System.EventHandler(this.timerAnimateSavedNotification_Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDownTimesWatched);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.richTextBoxDescription);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.richTextBoxGenres);
			this.groupBox1.Location = new System.Drawing.Point(354, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(282, 217);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Detail";
			// 
			// numericUpDownTimesWatched
			// 
			this.numericUpDownTimesWatched.Font = new System.Drawing.Font("Fira Code", 9F);
			this.numericUpDownTimesWatched.Location = new System.Drawing.Point(187, 21);
			this.numericUpDownTimesWatched.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownTimesWatched.Name = "numericUpDownTimesWatched";
			this.numericUpDownTimesWatched.Size = new System.Drawing.Size(82, 26);
			this.numericUpDownTimesWatched.TabIndex = 6;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(13, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(171, 17);
			this.label10.TabIndex = 5;
			this.label10.Text = "Number of times watched:";
			// 
			// richTextBoxDescription
			// 
			this.richTextBoxDescription.Location = new System.Drawing.Point(16, 136);
			this.richTextBoxDescription.Name = "richTextBoxDescription";
			this.richTextBoxDescription.Size = new System.Drawing.Size(253, 68);
			this.richTextBoxDescription.TabIndex = 4;
			this.richTextBoxDescription.Text = "";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 116);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 17);
			this.label9.TabIndex = 3;
			this.label9.Text = "Description:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 17);
			this.label8.TabIndex = 2;
			this.label8.Text = "Genres:";
			// 
			// richTextBoxGenres
			// 
			this.richTextBoxGenres.Location = new System.Drawing.Point(16, 68);
			this.richTextBoxGenres.Name = "richTextBoxGenres";
			this.richTextBoxGenres.Size = new System.Drawing.Size(253, 35);
			this.richTextBoxGenres.TabIndex = 0;
			this.richTextBoxGenres.Text = "";
			// 
			// btnFavorite
			// 
			this.btnFavorite.BackColor = System.Drawing.Color.Transparent;
			this.btnFavorite.FlatAppearance.BorderSize = 0;
			this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFavorite.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorite.Image")));
			this.btnFavorite.Location = new System.Drawing.Point(493, 20);
			this.btnFavorite.Name = "btnFavorite";
			this.btnFavorite.Size = new System.Drawing.Size(47, 48);
			this.btnFavorite.TabIndex = 15;
			this.btnFavorite.UseVisualStyleBackColor = false;
			this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 373);
			this.Controls.Add(this.btnFavorite);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBoxSchedule);
			this.Controls.Add(this.numericUpDownSeasons);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtboxName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = global::TvSeriesLogs.Properties.Resources.icon_edit;
			this.KeyPreview = true;
			this.Name = "EditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit";
			this.Shown += new System.EventHandler(this.EditForm_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).EndInit();
			this.groupBoxSchedule.ResumeLayout(false);
			this.groupBoxSchedule.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScheduleEpisode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScheduleSeasons)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimesWatched)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtboxName;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.NumericUpDown numericUpDownSeasons;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBoxSchedule;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		internal System.Windows.Forms.NumericUpDown numericUpDownScheduleSeasons;
		internal System.Windows.Forms.NumericUpDown numericUpDownScheduleEpisode;
		private System.Windows.Forms.DateTimePicker dateTimePickerInterruptionTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerShowStartsAtDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerShowStartsAtTime;
		private System.Windows.Forms.Timer timerAnimateSavedNotification;
		private System.Windows.Forms.Button btnResetScheduleInterruptionTime;
		private System.Windows.Forms.Button btnResetScheduleStartsAt;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox richTextBoxGenres;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RichTextBox richTextBoxDescription;
		internal System.Windows.Forms.NumericUpDown numericUpDownTimesWatched;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnFavorite;
	}
}