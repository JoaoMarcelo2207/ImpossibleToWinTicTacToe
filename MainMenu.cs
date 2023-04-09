using System;
using System.Windows.Forms;

namespace ImpossibleToWinTicTacToe
{
    public partial class MainMenu : Form
    {
        Game game;
        AboutMenu aboutMenu;
        AdminLogin adminLoginMenu;
        public MainMenu()
        {
            InitializeComponent();
            
        }

      
        private void playButton_Click(object sender, EventArgs e)
        {
            
            game.Show();
            this.Hide();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
         
            
            aboutMenu.Show();
            this.Hide();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            
            adminLoginMenu.Show();
            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            adminLoginMenu = new AdminLogin();
            aboutMenu = new AboutMenu();
            game = new Game();
        }

    }
}
