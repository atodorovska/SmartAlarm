namespace AlarmClock
{
    partial class Difficulty
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
            this.easy = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.difficultyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the difficulty of the game!";
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.Location = new System.Drawing.Point(16, 61);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(62, 24);
            this.easy.TabIndex = 1;
            this.easy.TabStop = true;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium.Location = new System.Drawing.Point(116, 61);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(83, 24);
            this.medium.TabIndex = 2;
            this.medium.TabStop = true;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.Location = new System.Drawing.Point(236, 61);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(62, 24);
            this.hard.TabIndex = 3;
            this.hard.TabStop = true;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // difficultyBtn
            // 
            this.difficultyBtn.Location = new System.Drawing.Point(12, 118);
            this.difficultyBtn.Name = "difficultyBtn";
            this.difficultyBtn.Size = new System.Drawing.Size(289, 23);
            this.difficultyBtn.TabIndex = 4;
            this.difficultyBtn.Text = "Continue";
            this.difficultyBtn.UseVisualStyleBackColor = true;
            this.difficultyBtn.Click += new System.EventHandler(this.difficultyBtn_Click);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 160);
            this.Controls.Add(this.difficultyBtn);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.label1);
            this.Name = "Difficulty";
            this.Text = "Difficulty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.Button difficultyBtn;
    }
}