namespace MineSweeper.Views.Forms
{
    partial class InputBoxForm
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
            this.acceptPlayerNameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceptPlayerNameButton
            // 
            this.acceptPlayerNameButton.Location = new System.Drawing.Point(116, 52);
            this.acceptPlayerNameButton.Name = "acceptPlayerNameButton";
            this.acceptPlayerNameButton.Size = new System.Drawing.Size(75, 23);
            this.acceptPlayerNameButton.TabIndex = 0;
            this.acceptPlayerNameButton.Text = "Enter";
            this.acceptPlayerNameButton.UseVisualStyleBackColor = true;
            this.acceptPlayerNameButton.Click += new System.EventHandler(this.acceptPlayerNameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your name:";
            // 
            // playerNameBox
            // 
            this.playerNameBox.Location = new System.Drawing.Point(15, 25);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(176, 20);
            this.playerNameBox.TabIndex = 2;
            // 
            // InputBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 87);
            this.Controls.Add(this.playerNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptPlayerNameButton);
            this.Name = "InputBoxForm";
            this.Text = "Player Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptPlayerNameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerNameBox;
    }
}