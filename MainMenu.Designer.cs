
namespace ImpossibleToWinTicTacToe
{
    partial class MainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuTitle = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuTitle
            // 
            this.menuTitle.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitle.Location = new System.Drawing.Point(67, 23);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(250, 53);
            this.menuTitle.TabIndex = 0;
            this.menuTitle.Text = "Impossible to Win \r\n   tic tac toe";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(71, 128);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(246, 46);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play :)";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("NSimSun", 14.25F);
            this.aboutButton.Location = new System.Drawing.Point(71, 208);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(246, 46);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("NSimSun", 14.25F);
            this.adminButton.Location = new System.Drawing.Point(231, 284);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(140, 30);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Admin Access";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 326);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.menuTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impossible To Win Tic Tac Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button adminButton;
    }
}

