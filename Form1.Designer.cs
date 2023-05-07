namespace test_game
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.head = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.blockLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.head.Location = new System.Drawing.Point(374, 306);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(30, 30);
            this.head.TabIndex = 0;
            this.head.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 146);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(59, 15);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score: 0";
            // 
            // blockLabel
            // 
            this.blockLabel.AutoSize = true;
            this.blockLabel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockLabel.Location = new System.Drawing.Point(12, 187);
            this.blockLabel.Name = "blockLabel";
            this.blockLabel.Size = new System.Drawing.Size(67, 15);
            this.blockLabel.TabIndex = 2;
            this.blockLabel.Text = "Blocks: 0";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timerLabel.Location = new System.Drawing.Point(12, 103);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(59, 15);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "Timer: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "One Minute Game";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.startButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(685, 103);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 99);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButtonClick);
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Location = new System.Drawing.Point(685, 12);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(75, 85);
            this.pictureBoxArrow.TabIndex = 6;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDrawingArrow);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 649);
            this.Controls.Add(this.pictureBoxArrow);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.blockLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.head);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.paintForm);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox head;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label blockLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
    }
}

