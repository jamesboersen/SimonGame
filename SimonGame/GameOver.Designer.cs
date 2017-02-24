namespace SimonGame
{
    partial class GameOver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.endGameButton = new System.Windows.Forms.Button();
            this.roundsPlayedLabel = new System.Windows.Forms.Label();
            this.roundsPlayedOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(81, 63);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(153, 31);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "Game Over";
            // 
            // endGameButton
            // 
            this.endGameButton.Location = new System.Drawing.Point(108, 164);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(75, 23);
            this.endGameButton.TabIndex = 1;
            this.endGameButton.Text = "End Game";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // roundsPlayedLabel
            // 
            this.roundsPlayedLabel.AutoSize = true;
            this.roundsPlayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsPlayedLabel.Location = new System.Drawing.Point(40, 234);
            this.roundsPlayedLabel.Name = "roundsPlayedLabel";
            this.roundsPlayedLabel.Size = new System.Drawing.Size(143, 24);
            this.roundsPlayedLabel.TabIndex = 2;
            this.roundsPlayedLabel.Text = "Rounds Played:";
            // 
            // roundsPlayedOutput
            // 
            this.roundsPlayedOutput.AutoSize = true;
            this.roundsPlayedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsPlayedOutput.Location = new System.Drawing.Point(189, 234);
            this.roundsPlayedOutput.Name = "roundsPlayedOutput";
            this.roundsPlayedOutput.Size = new System.Drawing.Size(0, 24);
            this.roundsPlayedOutput.TabIndex = 3;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.roundsPlayedOutput);
            this.Controls.Add(this.roundsPlayedLabel);
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.Label roundsPlayedLabel;
        private System.Windows.Forms.Label roundsPlayedOutput;
    }
}
