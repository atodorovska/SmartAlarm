namespace AlarmClock
{
    partial class Form1
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
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.upDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.upDownHours = new System.Windows.Forms.NumericUpDown();
            this.upDownPMAM = new System.Windows.Forms.DomainUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.upDownSnooze = new System.Windows.Forms.NumericUpDown();
            this.upDownTimes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAlarms = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbSongs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSnooze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Location = new System.Drawing.Point(254, 67);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnSetAlarm.TabIndex = 0;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(30, 27);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.Value = new System.DateTime(2018, 5, 28, 0, 0, 0, 0);
            // 
            // upDownMinutes
            // 
            this.upDownMinutes.Location = new System.Drawing.Point(96, 67);
            this.upDownMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.upDownMinutes.Name = "upDownMinutes";
            this.upDownMinutes.Size = new System.Drawing.Size(60, 20);
            this.upDownMinutes.TabIndex = 3;
            this.upDownMinutes.ValueChanged += new System.EventHandler(this.upDownMinutes_ValueChanged);
            // 
            // upDownHours
            // 
            this.upDownHours.Location = new System.Drawing.Point(30, 67);
            this.upDownHours.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.upDownHours.Name = "upDownHours";
            this.upDownHours.Size = new System.Drawing.Size(60, 20);
            this.upDownHours.TabIndex = 4;
            this.upDownHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownHours.ValueChanged += new System.EventHandler(this.upDownHours_ValueChanged);
            // 
            // upDownPMAM
            // 
            this.upDownPMAM.Items.Add("PM");
            this.upDownPMAM.Items.Add("AM");
            this.upDownPMAM.Location = new System.Drawing.Point(162, 67);
            this.upDownPMAM.Name = "upDownPMAM";
            this.upDownPMAM.ReadOnly = true;
            this.upDownPMAM.Size = new System.Drawing.Size(68, 20);
            this.upDownPMAM.TabIndex = 5;
            this.upDownPMAM.Text = "PM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // upDownSnooze
            // 
            this.upDownSnooze.Location = new System.Drawing.Point(96, 109);
            this.upDownSnooze.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.upDownSnooze.Name = "upDownSnooze";
            this.upDownSnooze.Size = new System.Drawing.Size(60, 20);
            this.upDownSnooze.TabIndex = 6;
            this.upDownSnooze.ValueChanged += new System.EventHandler(this.upDownSnooze_ValueChanged);
            // 
            // upDownTimes
            // 
            this.upDownTimes.Location = new System.Drawing.Point(96, 147);
            this.upDownTimes.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownTimes.Name = "upDownTimes";
            this.upDownTimes.Size = new System.Drawing.Size(60, 20);
            this.upDownTimes.TabIndex = 7;
            this.upDownTimes.ValueChanged += new System.EventHandler(this.upDownTimes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Snooze:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Limit:";
            // 
            // lbAlarms
            // 
            this.lbAlarms.FormattingEnabled = true;
            this.lbAlarms.Location = new System.Drawing.Point(237, 164);
            this.lbAlarms.Name = "lbAlarms";
            this.lbAlarms.Size = new System.Drawing.Size(224, 173);
            this.lbAlarms.TabIndex = 10;
            this.lbAlarms.SelectedIndexChanged += new System.EventHandler(this.lbAlarms_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(305, 135);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(386, 135);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(30, 187);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(150, 82);
            this.lbSongs.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbAlarms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upDownTimes);
            this.Controls.Add(this.upDownSnooze);
            this.Controls.Add(this.upDownPMAM);
            this.Controls.Add(this.upDownHours);
            this.Controls.Add(this.upDownMinutes);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.btnSetAlarm);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSnooze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.NumericUpDown upDownMinutes;
        private System.Windows.Forms.NumericUpDown upDownHours;
        private System.Windows.Forms.DomainUpDown upDownPMAM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown upDownSnooze;
        private System.Windows.Forms.NumericUpDown upDownTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAlarms;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox lbSongs;
    }
}

