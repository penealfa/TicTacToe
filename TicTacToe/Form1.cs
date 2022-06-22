namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static int turn = 0;
        static int gamesPlayed = 0;
        static int P1wonCount = 0;
        static int P2wonCount = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                btn1.Text = "X";
                CheckWinner();
                btnP1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP2.BackColor = Color.White;
                turn++;
            }
            else if (turn == 1)
            {
                btn1.Text = "O";
                CheckWinner();
                btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP1.BackColor = Color.White;
                turn--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (turn == 0)
            {
                btn2.Text = "X";
                CheckWinner();
                btnP1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP2.BackColor = Color.White;
                turn++;
            }
            else if (turn == 1)
            {
                btn2.Text = "O";
                CheckWinner();
                btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP1.BackColor = Color.White;
                turn--;
            }
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {

            if (turn == 0)
            {
                btn3.Text = "X";
                CheckWinner();
                btnP1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP2.BackColor = Color.White;
                turn++;
            }
            else if (turn == 1)
            {
                btn3.Text = "O";
                CheckWinner();
                btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP1.BackColor = Color.White;
                turn--;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                btn4.Text = "X";
                CheckWinner();
                btnP1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP2.BackColor = Color.White;
                turn++;
            }
            else if (turn == 1)
            {
                btn4.Text = "O";
                CheckWinner();
                btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP1.BackColor = Color.White;
                turn--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                btn5.Text = "X";
                CheckWinner();
                btnP1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP2.BackColor = Color.White;
                turn++;
            }
            else if (turn == 1)
            {
                btn5.Text = "O";
                CheckWinner();
                btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP1.BackColor = Color.White;
                turn--;
            }
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {

            if (turn == 0)
            {
                btn6.Text = "X";
                CheckWinner();
                btnP1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP2.BackColor = Color.White;
                turn++;
            }
            else if (turn == 1)
            {
                btn6.Text = "O";
                CheckWinner();
                btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP1.BackColor = Color.White;
                turn--;
            }
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                btn7.Text = "X";
                CheckWinner();
                btnP1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP2.BackColor = Color.White;
                turn++;
            }
            else if (turn == 1)
            {
                btn7.Text = "O";
                CheckWinner();
                btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP1.BackColor = Color.White;
                turn--;
            }
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                btn8.Text = "X";
                CheckWinner();
                btnP1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP2.BackColor = Color.White;
                turn++;
            }
            else if (turn == 1)
            {
                btn8.Text = "O";
                CheckWinner();
                btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP1.BackColor = Color.White;
                turn--;
            }
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                btn9.Text = "X";
                CheckWinner();
                btnP1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP2.BackColor = Color.White;
                turn++;
            }
            else if (turn == 1)
            {
                btn9.Text = "O";
                CheckWinner();
                btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                btnP1.BackColor = Color.White;
                turn--;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            btnP1.BackColor = Color.White;
        }
        private void CheckWinner()

        {
            if (btn1.Text == "O" & btn2.Text == "O" & btn3.Text == "O")
            {
                MessageBox.Show("Player 2 has Won");
                P2wonCount++;
                labelP2.Text = P2wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text= gamesPlayed.ToString(); 
                btnClear.PerformClick();

            }
            else if (btn4.Text == "O" & btn5.Text == "O" & btn6.Text == "O")
            {

                MessageBox.Show("Player 2 has Won");
                P2wonCount++;
                labelP2.Text = P2wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if (btn7.Text == "O" & btn8.Text == "O" & btn9.Text == "O")
            {
                MessageBox.Show("Player 2 has Won");
                P2wonCount++;
                labelP2.Text = P2wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if (btn1.Text == "O" & btn4.Text == "O" & btn7.Text == "O")
            {

                MessageBox.Show("Player 2 has Won");
                P2wonCount++;
                labelP2.Text = P2wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if (btn2.Text == "O" & btn5.Text == "O" & btn8.Text == "O")
            {

                MessageBox.Show("Player 2 has Won");
                P2wonCount++;
                labelP2.Text = P2wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if (btn3.Text == "O" & btn6.Text == "O" & btn9.Text == "O")
            {

                MessageBox.Show("Player 2 has Won");
                P2wonCount++;
                labelP2.Text = P2wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if (btn1.Text == "O" & btn5.Text == "O" & btn9.Text == "O")
            {

                MessageBox.Show("Player 2 has Won");
                P2wonCount++;
                labelP2.Text = P2wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if (btn3.Text == "O" & btn5.Text == "O" & btn7.Text == "O")
            {

                MessageBox.Show("Player 2 has Won");
                P2wonCount++;
                labelP2.Text = P2wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }

            if (btn1.Text=="X" & btn2.Text=="X" & btn3.Text=="X" )
            {
                MessageBox.Show("Player 1 has Won");
                P1wonCount++;
                labelP1.Text = P1wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();

            }
            else if(btn4.Text == "X" & btn5.Text == "X" & btn6.Text == "X")
            {

                MessageBox.Show("Player 1 has Won");
                P1wonCount++;
                labelP1.Text = P1wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if(btn7.Text == "X" & btn8.Text == "X" & btn9.Text == "X")
            {
                MessageBox.Show("Player 1 has Won");
                P1wonCount++;
                labelP1.Text = P1wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();

            }
            else if(btn1.Text == "X" & btn4.Text == "X" & btn7.Text == "X")
            {

                MessageBox.Show("Player 1 has Won");
                P1wonCount++;
                labelP1.Text = P1wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if (btn2.Text == "X" & btn5.Text == "X" & btn8.Text == "X")
            {

                MessageBox.Show("Player 1 has Won");
                P1wonCount++;
                labelP1.Text = P1wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if (btn3.Text == "X" & btn6.Text == "X" & btn9.Text == "X")
            {

                MessageBox.Show("Player 1 has Won");
                P1wonCount++;
                labelP1.Text = P1wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if (btn1.Text == "X" & btn5.Text == "X" & btn9.Text == "X")
            {

                MessageBox.Show("Player 1 has Won");
                P1wonCount++;
                labelP1.Text = P1wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
            else if(btn3.Text == "X" & btn5.Text == "X" & btn7.Text == "X")
            {

                MessageBox.Show("Player 1 has Won");
                P1wonCount++;
                labelP1.Text = P1wonCount.ToString();
                gamesPlayed++;
                btnTotal.Text = gamesPlayed.ToString();
                btnClear.PerformClick();
            }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            labelP1.Text = "0";
            labelP2.Text = "0";
            btnTotal.Text = "0";
            btnP2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            btnP1.BackColor = Color.White; 
            turn = 0;
        }
    }
}