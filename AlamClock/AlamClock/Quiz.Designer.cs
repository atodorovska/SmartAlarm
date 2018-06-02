namespace AlarmClock
{
    partial class Quiz
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
            this.wordQuess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.equation = new System.Windows.Forms.Button();
            this.numbrGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordQuess
            // 
            this.wordQuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordQuess.Location = new System.Drawing.Point(12, 62);
            this.wordQuess.Name = "wordQuess";
            this.wordQuess.Size = new System.Drawing.Size(323, 35);
            this.wordQuess.TabIndex = 0;
            this.wordQuess.Text = "Guess the word";
            this.wordQuess.UseVisualStyleBackColor = true;
            this.wordQuess.Click += new System.EventHandler(this.wordQuess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chose which quiz you want to take!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equation
            // 
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.Location = new System.Drawing.Point(12, 103);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(323, 35);
            this.equation.TabIndex = 4;
            this.equation.Text = "Solve equation";
            this.equation.UseVisualStyleBackColor = true;
            this.equation.Click += new System.EventHandler(this.equation_Click);
            // 
            // numbrGuess
            // 
            this.numbrGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbrGuess.Location = new System.Drawing.Point(12, 144);
            this.numbrGuess.Name = "numbrGuess";
            this.numbrGuess.Size = new System.Drawing.Size(323, 35);
            this.numbrGuess.TabIndex = 5;
            this.numbrGuess.Text = "Guess the number";
            this.numbrGuess.UseVisualStyleBackColor = true;
            this.numbrGuess.Click += new System.EventHandler(this.numbrGuess_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 194);
            this.Controls.Add(this.numbrGuess);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordQuess);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wordQuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button equation;
        private System.Windows.Forms.Button numbrGuess;
    }
}