using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ImpossibleToWinTicTacToe
{
    public partial class Game : Form
    {
        MainMenu menu;
        int turnCounter = 0;
        bool turn = true, gameWinner = false;
        private Button[,] board = new Button[3, 3];
        int adminTimer = 0;
        public Game()
        {
            InitializeComponent();
            // starts an abstract board linked to the original board
            board[0, 0] = A1;
            board[0, 1] = A2;
            board[0, 2] = A3;
            board[1, 0] = B1;
            board[1, 1] = B2;
            board[1, 2] = B3;
            board[2, 0] = C1;
            board[2, 1] = C2;
            board[2, 2] = C3;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //if it's the player's turn
            if (turn)
            {
                //place the X and make the button not enabled
                b.Text = "X";
                turn = false;
                b.Enabled = false;
                turnCounter++;
                //check if the player won with this move and if he hasn't it's the AI turn
                winHandler();
                if (!gameWinner)
                {
                    bestMove();
                }

            }

        }

        private void bestMove()
        {
            double bestScore = double.NegativeInfinity;
            int[] move = new int[2];
            //look for an available position in the abstract board (linked with the original)
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(board[i,j].Text == "")
                    {
                        //places the O and call minimax function that's going to make a pontuation about this move and find the perfect move
                        board[i, j].Text = "O";
                        double score = minimax(board, 0, false);
                        board[i, j].Text = "";
                        if(score > bestScore)
                        {
                            bestScore = score;
                            move[0] = i;
                            move[1] = j;
                        }
                    }
                }
            }
            //after the perfect move is found, make it!
            board[move[0], move[1]].Text = "O";
            board[move[0], move[1]].Enabled = false;
            turnCounter++;
            winHandler();
            turn = true;
        }
        
        //pontuation for the minimax algorithm
        Dictionary<string, double> scores = new Dictionary<string, double>
        {
            { "X", -1 },
            { "O", 1 },
            { "tie", 0 }
        };
        
        //recursively finds the best movie looking in all scenarios and return the best pontuation
        private double minimax(Button[,] board, int depth, bool isMaxmizing)
        {
            String result = winChecker();
            if (result != null)
            {
                return scores[result];
            }

            if (isMaxmizing)
            {
                double bestScore = double.NegativeInfinity;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j].Text == "")
                        {
                            board[i, j].Text = "O";
                            double score = minimax(board, depth + 1, false);
                            board[i,j].Text = "";
                            bestScore = Math.Max(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                double bestScore = double.PositiveInfinity;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j].Text == "")
                        {
                            board[i, j].Text = "X";
                            double score = minimax(board, depth + 1, true);
                            board[i, j].Text = "";
                            bestScore = Math.Min(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }

            
        }
        
        //auxiliary function to check who won in one of the possibilities that the algorithm calcs
        private String winChecker()
        {
            String winner = null;
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0].Text == board[i, 1].Text && board[i, 1].Text == board[i, 2].Text && board[i,0].Text != "")
                {
                    winner = board[i,0].Text;
                    break;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i].Text == board[1, i].Text && board[1, i].Text == board[2, i].Text && board[0, i].Text != "")
                {
                    winner = board[0, i].Text;
                    break;
                }
            }

            if (board[0, 0].Text == board[1, 1].Text && board[1, 1].Text == board[2, 2].Text && board[0, 0].Text != "")
            {
                winner = board[0,0].Text;
            }

            if(board[2, 0].Text == board[1, 1].Text && board[1, 1].Text == board[0, 2].Text && board[2, 0].Text != "")
            {
                winner = board[2, 0].Text;
            }
            int openButtons = 0;
            

           for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    if(board[i,j].Text == "")
                    {
                        openButtons++;
                    }
                }
            }


            if (winner == null && openButtons == 0)
            {
                return "tie";
            }
            else
            {
                return winner;
            }

        }
        
        
         //function that check if someone wins
        private void winHandler()
        {
            bool winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) winner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled)) winner = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)) winner = true;

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) winner = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled)) winner = true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled)) winner = true;

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) winner = true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled)) winner = true;

            if (winner)
            {
                disableAllButtons();
                if (turn)
                {
                    String gameWinnerName = "You";
                    MessageBox.Show(gameWinnerName + " Wins!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gameWinner = true;
                }
                else
                {
                    String gameWinnerName = "I";
                    MessageBox.Show(gameWinnerName + " Win :)!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gameWinner = true;
                }
                
               
            }
            else
            {
                if(turnCounter == 9)
                {
                    gameWinner = true;
                    MessageBox.Show("Draw but you still don't win :)",
                        "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                  
                }
            }
        

        }

        private void Game_Load(object sender, EventArgs e)
        {
            menu = new MainMenu();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }
        
        //function to show the admin user and password
        private void Game_Click(object sender, EventArgs e)
        {
            adminTimer++;
            if(adminTimer == 15)
            {
                MessageBox.Show("Admin login: admin" + "\n" +
                    "Admin Password: DoNotLogin", "Danger", 
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        
        //function to disable all buttons after someone wins
        private void disableAllButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    if(b.Text != "I give up" && b.Text != "Main Menu")
                    {
                        b.Enabled = false;
                    }
                        
                }
            }
            catch { }
        }
    }
}
