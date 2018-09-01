namespace MineSweeper.Forms
{
    partial class DifficultySelectionForm
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
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.radioBtnEasy = new System.Windows.Forms.RadioButton();
            this.radioBtnMedium = new System.Windows.Forms.RadioButton();
            this.radioBtnHard = new System.Windows.Forms.RadioButton();
            this.playGameBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(10, 10);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(134, 13);
            this.difficultyLabel.TabIndex = 0;
            this.difficultyLabel.Text = "Please select your difficulty";
            // 
            // radioBtnEasy
            // 
            this.radioBtnEasy.AutoSize = true;
            this.radioBtnEasy.Location = new System.Drawing.Point(13, 26);
            this.radioBtnEasy.Name = "radioBtnEasy";
            this.radioBtnEasy.Size = new System.Drawing.Size(48, 17);
            this.radioBtnEasy.TabIndex = 1;
            this.radioBtnEasy.TabStop = true;
            this.radioBtnEasy.Text = "Easy";
            this.radioBtnEasy.UseVisualStyleBackColor = true;
            // 
            // radioBtnMedium
            // 
            this.radioBtnMedium.AutoSize = true;
            this.radioBtnMedium.Location = new System.Drawing.Point(13, 49);
            this.radioBtnMedium.Name = "radioBtnMedium";
            this.radioBtnMedium.Size = new System.Drawing.Size(62, 17);
            this.radioBtnMedium.TabIndex = 2;
            this.radioBtnMedium.TabStop = true;
            this.radioBtnMedium.Text = "Medium";
            this.radioBtnMedium.UseVisualStyleBackColor = true;
            // 
            // radioBtnHard
            // 
            this.radioBtnHard.AutoSize = true;
            this.radioBtnHard.Location = new System.Drawing.Point(13, 72);
            this.radioBtnHard.Name = "radioBtnHard";
            this.radioBtnHard.Size = new System.Drawing.Size(48, 17);
            this.radioBtnHard.TabIndex = 3;
            this.radioBtnHard.TabStop = true;
            this.radioBtnHard.Text = "Hard";
            this.radioBtnHard.UseVisualStyleBackColor = true;
            // 
            // playGameBTN
            // 
            this.playGameBTN.Location = new System.Drawing.Point(197, 126);
            this.playGameBTN.Name = "playGameBTN";
            this.playGameBTN.Size = new System.Drawing.Size(75, 23);
            this.playGameBTN.TabIndex = 4;
            this.playGameBTN.Text = "Play Game";
            this.playGameBTN.UseVisualStyleBackColor = true;
            this.playGameBTN.Click += new System.EventHandler(this.playGameBTN_Click);
            // 
            // DifficultySelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.playGameBTN);
            this.Controls.Add(this.radioBtnHard);
            this.Controls.Add(this.radioBtnMedium);
            this.Controls.Add(this.radioBtnEasy);
            this.Controls.Add(this.difficultyLabel);
            this.Name = "DifficultySelectionForm";
            this.Text = "DifficultySelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.RadioButton radioBtnEasy;
        private System.Windows.Forms.RadioButton radioBtnMedium;
        private System.Windows.Forms.RadioButton radioBtnHard;
        private System.Windows.Forms.Button playGameBTN;
    }
}