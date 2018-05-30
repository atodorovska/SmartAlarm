namespace AlarmClock
{
    partial class SnoozeIt
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
            this.Stop = new System.Windows.Forms.Button();
            this.snooze = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(47, 72);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 0;
            this.Stop.Text = "I\'m awake";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // snooze
            // 
            this.snooze.Location = new System.Drawing.Point(154, 72);
            this.snooze.Name = "snooze";
            this.snooze.Size = new System.Drawing.Size(75, 23);
            this.snooze.TabIndex = 1;
            this.snooze.Text = "Snooze!";
            this.snooze.UseVisualStyleBackColor = true;
            this.snooze.Click += new System.EventHandler(this.snooze_Click);
            // 
            // SnoozeIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 168);
            this.Controls.Add(this.snooze);
            this.Controls.Add(this.Stop);
            this.Name = "SnoozeIt";
            this.Text = "SnoozeIt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button snooze;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}