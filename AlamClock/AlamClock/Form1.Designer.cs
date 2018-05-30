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
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSnooze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Location = new System.Drawing.Point(279, 118);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnSetAlarm.TabIndex = 0;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(55, 78);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.Value = new System.DateTime(2018, 5, 28, 0, 0, 0, 0);
            // 
            // upDownMinutes
            // 
            this.upDownMinutes.Location = new System.Drawing.Point(121, 118);
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
            this.upDownHours.Location = new System.Drawing.Point(55, 118);
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
            this.upDownPMAM.Location = new System.Drawing.Point(187, 118);
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
            this.upDownSnooze.Location = new System.Drawing.Point(121, 160);
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
            this.upDownTimes.Location = new System.Drawing.Point(121, 198);
            this.upDownTimes.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownTimes.Name = "upDownTimes";
            this.upDownTimes.Size = new System.Drawing.Size(60, 20);
            this.upDownTimes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Snooze:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Limit:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
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
            this.Text = "Smart Alarm";
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
    }
}

