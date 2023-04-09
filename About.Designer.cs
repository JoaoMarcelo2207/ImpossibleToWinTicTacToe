
namespace ImpossibleToWinTicTacToe
{
    partial class AboutMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMenu));
            this.leaveButton = new System.Windows.Forms.Button();
            this.aboutText = new System.Windows.Forms.Label();
            this.aboutText2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(86, 196);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(201, 38);
            this.leaveButton.TabIndex = 0;
            this.leaveButton.Text = "Leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // aboutText
            // 
            this.aboutText.AutoSize = true;
            this.aboutText.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutText.Location = new System.Drawing.Point(-1, 38);
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(394, 105);
            this.aboutText.TabIndex = 1;
            this.aboutText.Text = "This game is about tic tac toe, I guess that\r\nyou know how to play and if not jus" +
    "t google.\r\nThere\'s a catch in this game, you can\'t win.\r\n\r\n                     " +
    "  good luck :)";
            // 
            // aboutText2
            // 
            this.aboutText2.AutoSize = true;
            this.aboutText2.Font = new System.Drawing.Font("NSimSun", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutText2.Location = new System.Drawing.Point(12, 287);
            this.aboutText2.Name = "aboutText2";
            this.aboutText2.Size = new System.Drawing.Size(250, 15);
            this.aboutText2.TabIndex = 2;
            this.aboutText2.Text = "ps: do not enter admin mode";
            // 
            // AboutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 326);
            this.Controls.Add(this.aboutText2);
            this.Controls.Add(this.aboutText);
            this.Controls.Add(this.leaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutMenu_FormClosed);
            this.Load += new System.EventHandler(this.AboutMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Label aboutText;
        private System.Windows.Forms.Label aboutText2;
    }
}