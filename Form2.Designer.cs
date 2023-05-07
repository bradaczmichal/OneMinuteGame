namespace test_game
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelYourScore = new System.Windows.Forms.Label();
            this.okayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "One Minute Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "TIME OUT";
            // 
            // labelYourScore
            // 
            this.labelYourScore.AutoSize = true;
            this.labelYourScore.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourScore.Location = new System.Drawing.Point(178, 177);
            this.labelYourScore.Name = "labelYourScore";
            this.labelYourScore.Size = new System.Drawing.Size(207, 33);
            this.labelYourScore.TabIndex = 7;
            this.labelYourScore.Text = "Your score: 0";
            // 
            // okayButton
            // 
            this.okayButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.okayButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okayButton.Location = new System.Drawing.Point(109, 239);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(334, 117);
            this.okayButton.TabIndex = 8;
            this.okayButton.Text = "OKAY";
            this.okayButton.UseVisualStyleBackColor = false;
            this.okayButton.Click += new System.EventHandler(this.okayButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(109, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(334, 117);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 536);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.labelYourScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Click += new System.EventHandler(this.exitButtonClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okayButton;
        public System.Windows.Forms.Label labelYourScore;
        private System.Windows.Forms.Button exitButton;
    }
}