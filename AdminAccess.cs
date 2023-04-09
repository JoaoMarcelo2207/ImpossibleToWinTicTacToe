using System;
using System.IO;
using System.Windows.Forms;

namespace ImpossibleToWinTicTacToe
{
    public partial class AdminLogin : Form
    {
        MainMenu mainMenu;
        int adminTimer = 0;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {

            if(adminTimer == 3)
            {
                MessageBox.Show("There is no Escape from me :)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "read_me2.txt");

                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    sw.WriteLine("your ip: 192.168.0.0 :)");
                }
            }

            mainMenu.Show();
            this.Hide();


        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userTextBox.Text) 
               || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("All camps need to be filled!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if(userTextBox.Text != "admin" || passwordTextBox.Text != "DoNotLogin")
            {
                MessageBox.Show("Wrong User and/or Password", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else{
                adminTimer++;
                if (adminTimer == 1)
                {
                    MessageBox.Show("Don't", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(adminTimer == 2)
                {
                    MessageBox.Show("Last Chance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(adminTimer == 3)
                {
                    MessageBox.Show("You were warned :(", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "read_me.txt");

                    using (StreamWriter sw = new StreamWriter(filePath, false))
                    {
                        sw.WriteLine("get fvcked your pc is now mine :)");
                    }
                }
            }
            
        }
        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            mainMenu = new MainMenu();
        }
    }
}
