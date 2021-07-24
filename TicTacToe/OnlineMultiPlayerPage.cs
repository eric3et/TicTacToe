using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicTacToe
{
	public partial class OnlineMultiPlayerPage : Form
	{

		static Player p1 = new Player("X", "O"); // Team X, enemy = O
		static Player p2 = new Player("O", "X"); // Team O, enemy = X
		static Player[] players = { p1, p2 };
		


		// set initial turn to player X
		static int playerTurn = 0;
		Player currPlayer = players[playerTurn];

		private void ClearOldButton(string btnName)
		{

			foreach (Button b in panel1.Controls)
			{
				if(b.Name == btnName)
				{
					b.Text = " ";
				}
			}
		}

		private void DisableBox(string btnName)
		{
			foreach (Button b in panel1.Controls)
			{
				if (b.Name == btnName)
				{
					b.Enabled = false;
				}
			}
		}

		private void ChangeTurns()
		{
			if (playerTurn == 1)
			{
				playerTurn = 0;
				txtDisplay.Text = "X's Turn";
				lblDisplay.Text = "X";

			}
			else
			{
				playerTurn = 1;
				txtDisplay.Text = "O's Turn";
				lblDisplay.Text = "O";

			}
			currPlayer = players[playerTurn];
		}

		private void CheckWin()
		{
			int[] numArray = new int[9];
			int i = 0;


			foreach (Button b in panel1.Controls)
			{
				
				if(b.Text == "X")
				{
					numArray[i] = 1;
				}
				else if(b.Text == "O")
				{
					numArray[i] = 0;
				}
				else
				{
					numArray[i] = 2;
				}
				i++;

			}

			if (	(numArray[0] == 1 && numArray[1] == 1 && numArray[2] == 1) //row1
				||	(numArray[3] == 1 && numArray[4] == 1 && numArray[5] == 1) //row2
				||	(numArray[6] == 1 && numArray[7] == 1 && numArray[8] == 1) //row3
				||	(numArray[0] == 1 && numArray[3] == 1 && numArray[6] == 1) //col1
				||	(numArray[1] == 1 && numArray[4] == 1 && numArray[7] == 1) //col2
				||	(numArray[2] == 1 && numArray[5] == 1 && numArray[8] == 1) //col3
				||	(numArray[0] == 1 && numArray[4] == 1 && numArray[8] == 1) //diag1
				||	(numArray[2] == 1 && numArray[4] == 1 && numArray[6] == 1) //diag2
			){ 
				txtDisplay.Text = "X Wins!";
				lblDisplay.Text = "";
				foreach (Button b in panel1.Controls)
				{
					b.Enabled = false;
				}
				btnReset.Location = new Point(13, 18);
				btnReset.Size = new Size(157,41);
				btnReset.Text = "Play Again?";
				btnReset.BackColor = Color.LightBlue;
				btnSubmit.Enabled = false;
			}
			else if (	(numArray[0] == 0 && numArray[1] == 0 && numArray[2] == 0) //row1
				||		(numArray[3] == 0 && numArray[4] == 0 && numArray[5] == 0) //row2
				||		(numArray[6] == 0 && numArray[7] == 0 && numArray[8] == 0) //row3
				||		(numArray[0] == 0 && numArray[3] == 0 && numArray[6] == 0) //col1
				||		(numArray[1] == 0 && numArray[4] == 0 && numArray[7] == 0) //col2
				||		(numArray[2] == 0 && numArray[5] == 0 && numArray[8] == 0) //col3
				||		(numArray[0] == 0 && numArray[4] == 0 && numArray[8] == 0) //diag1
				||		(numArray[2] == 0 && numArray[4] == 0 && numArray[6] == 0) //diag2
			){
				txtDisplay.Text = "O Wins!";
				lblDisplay.Text = "";
				foreach (Button b in panel1.Controls)
				{
					b.Enabled = false;
				}
				btnReset.Location = new Point(13, 18);
				btnReset.Size = new Size(157, 41);
				btnReset.Text = "Play Again?";
				btnReset.BackColor = Color.LightBlue;
				btnSubmit.Enabled = false;
			}
			



		}

		public OnlineMultiPlayerPage()
		{

			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

			txtDisplay.Text = "X's Turn";

			

		}

		private void btn1_Click(object sender, EventArgs e)
		{

				if (currPlayer.currentMove != currPlayer.team || currPlayer.currentMove != currPlayer.enemy)
				{
					ClearOldButton(currPlayer.currentMove);
				}
				currPlayer.currentMove = btn1.Name;
				btn1.Text = currPlayer.team;
			
		}

		private void btn2_Click(object sender, EventArgs e)
		{

				if (currPlayer.currentMove != currPlayer.team || currPlayer.currentMove != currPlayer.enemy)
				{
					ClearOldButton(currPlayer.currentMove);
				}
				currPlayer.currentMove = btn2.Name;
				btn2.Text = currPlayer.team;
			
		}

		private void btn3_Click(object sender, EventArgs e)
		{

				if (currPlayer.currentMove != currPlayer.team || currPlayer.currentMove != currPlayer.enemy)
				{
					ClearOldButton(currPlayer.currentMove);
				}
				currPlayer.currentMove = btn3.Name;
				btn3.Text = currPlayer.team;
			
		}

		private void btn4_Click(object sender, EventArgs e)
		{

				if (currPlayer.currentMove != currPlayer.team || currPlayer.currentMove != currPlayer.enemy)
				{
					ClearOldButton(currPlayer.currentMove);
				}
				currPlayer.currentMove = btn4.Name;
				btn4.Text = currPlayer.team;
			
		}

		private void btn5_Click(object sender, EventArgs e)
		{

				if (currPlayer.currentMove != currPlayer.team || currPlayer.currentMove != currPlayer.enemy)
				{
					ClearOldButton(currPlayer.currentMove);
				}
				currPlayer.currentMove = btn5.Name;
				btn5.Text = currPlayer.team;
			
		}

		private void btn6_Click(object sender, EventArgs e)
		{

				if (currPlayer.currentMove != currPlayer.team || currPlayer.currentMove != currPlayer.enemy)
				{
					ClearOldButton(currPlayer.currentMove);
				}
				currPlayer.currentMove = btn6.Name;
				btn6.Text = currPlayer.team;
			
		}

		private void btn7_Click(object sender, EventArgs e)
		{

				if (currPlayer.currentMove != currPlayer.team || currPlayer.currentMove != currPlayer.enemy)
				{
					ClearOldButton(currPlayer.currentMove);
				}
				currPlayer.currentMove = btn7.Name;
				btn7.Text = currPlayer.team;
			
		}

		private void btn8_Click(object sender, EventArgs e)
		{

				if (currPlayer.currentMove != currPlayer.team || currPlayer.currentMove != currPlayer.enemy)
				{
					ClearOldButton(currPlayer.currentMove);
				}
				currPlayer.currentMove = btn8.Name;
				btn8.Text = currPlayer.team;
			
		}

		private void btn9_Click(object sender, EventArgs e)
		{

				if (currPlayer.currentMove != currPlayer.team || currPlayer.currentMove != currPlayer.enemy)
				{
					ClearOldButton(currPlayer.currentMove);
				}
				currPlayer.currentMove = btn9.Name;
				btn9.Text = currPlayer.team;
			
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (currPlayer.currentMove == " ")
			{
				txtDisplay.Text = currPlayer.team + "'s Turn - Make a Move Before Submitting";
			}
			else
			{

				DisableBox(currPlayer.currentMove);
				currPlayer.currentMove = " ";

				ChangeTurns();
				CheckWin();
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			btnReset.BackColor = Color.Salmon;
			btnReset.Location = new Point(62, 18);
			btnReset.Size = new Size(108, 41);
			playerTurn = 0;
			currPlayer = players[playerTurn];
			txtDisplay.Text = currPlayer.team + "'s Turn";
			lblDisplay.Text = currPlayer.team;
			btnReset.Text = "Reset";
			btnSubmit.Enabled = true;


			foreach (Button b in panel1.Controls)
			{
				b.Enabled = true;
				b.Text = " ";
			}
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
