using System;
using System.Windows.Forms;

namespace ImpossibleToWinTicTacToe
{
    public partial class AboutMenu : Form
    {
        MainMenu mainMenu;
        int leaveTimer = 0;
        public AboutMenu()
        {
            InitializeComponent();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            if (leaveTimer == 2)
            {
                leaveTimer = 0;
                
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You can't leave :(", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                leaveTimer++;
            }
            
        }

        private void AboutMenu_Load(object sender, EventArgs e)
        {
            mainMenu = new MainMenu();
        }

        private void AboutMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
