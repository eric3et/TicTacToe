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
	public partial class SinglePlayerPage : Form
	{

		static Player p1 = new Player("X", "O"); // Team X, enemy = O
		static Player p2 = new Player("O", "X"); // Team O, enemy = X
		static Player[] players = { p1, p2 };
		static int alternateTurns = 0;



		// set initial turn to player X
		static int playerTurn = alternateTurns;
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

		private async void OpponentPickBox()
		{
				Button b = OpponentWin();

					if (currPlayer.team == "O")
					{
						currPlayer.currentMove = b.Name;
						await Task.Delay(100);
						b.Text = currPlayer.team;
						btnSubmit.Text = "Submit";
						await Task.Delay(100);
						btnSubmit.PerformClick();
					}
					
				
			
		}

		private Button OpponentPickNextAvailableBox()
		{

			//Try to pick a corner first else pick random
			if (btn7.Enabled == true) return btn7;
			else if (btn9.Enabled == true) return btn9;
			else if (btn3.Enabled == true) return btn3;
			else if (btn1.Enabled == true) return btn1;
			else
			{


				Random r = new Random();

				foreach (Button b in panel1.Controls)
				{
					if (b.Enabled == true)
					{
						return b;
					}


				}
				return btnSubmit;
			}
		}


		
		//Check to see if any row,col,diag is one away from win, if it is select it
		private Button OpponentWin()
		{

			//Create a string array showing positions and empty slots
			string[] strArray = new string[9];
			int i = 0;


			foreach (Button b in panel1.Controls)
			{

				if (b.Text == "X")
				{
					strArray[i] = "X";
				}
				else if (b.Text == "O")
				{
					strArray[i] = "O";
				}
				else
				{
					strArray[i] = "E";
				}
				i++;

			}

			//Opponent picking system priority
			//Check for one away wins
			//Check for one away losses/blocks
			//pick corners
			//pick next available
			switch(strArray[0] + strArray[1] + strArray[2])//Row1
			{
				case "OOE":
					return btn3;
					break;

				case "OEO":
					return btn2;
					break;

				case "EOO":
					return btn1;
					break;

				default:
					switch (strArray[3] + strArray[4] + strArray[5])//Row2
					{
						case "OOE":
							return btn6;
							break;

						case "OEO":
							return btn5;
							break;

						case "EOO":
							return btn4;
							break;

						default:
							switch (strArray[6] + strArray[7] + strArray[8])//Row3
							{
								case "OOE":
									return btn9;
									break;

								case "OEO":
									return btn8;
									break;

								case "EOO":
									return btn7;
									break;

								default:
									switch (strArray[0] + strArray[3] + strArray[6])//Col1
									{
										case "OOE":
											return btn7;
											break;

										case "OEO":
											return btn4;
											break;

										case "EOO":
											return btn1;
											break;

										default:
											switch (strArray[1] + strArray[4] + strArray[7])//Col2
											{
												case "OOE":
													return btn8;
													break;

												case "OEO":
													return btn5;
													break;

												case "EOO":
													return btn2;
													break;

												default:
													switch (strArray[2] + strArray[5] + strArray[8])//Col3
													{
														case "OOE":
															return btn9;
															break;

														case "OEO":
															return btn6;
															break;

														case "EOO":
															return btn3;
															break;

														default:
															switch (strArray[0] + strArray[4] + strArray[8])//Diag1
															{
																case "OOE":
																	return btn9;
																	break;

																case "OEO":
																	return btn5;
																	break;

																case "EOO":
																	return btn1;
																	break;

																default:
																	switch (strArray[2] + strArray[4] + strArray[6])//Diag2
																	{
																		case "OOE":
																			return btn7;
																			break;

																		case "OEO":
																			return btn5;
																			break;

																		case "EOO":
																			return btn3;
																			break;

																		default:

																			switch (strArray[0] + strArray[1] + strArray[2])//Row1
																			{
																				case "XXE":
																					return btn3;
																					break;

																				case "XEX":
																					return btn2;
																					break;

																				case "EXX":
																					return btn1;
																					break;

																				default:
																					switch (strArray[3] + strArray[4] + strArray[5])//Row2
																					{
																						case "XXE":
																							return btn6;
																							break;

																						case "XEX":
																							return btn5;
																							break;

																						case "EXX":
																							return btn4;
																							break;

																						default:
																							switch (strArray[6] + strArray[7] + strArray[8])//Row3
																							{
																								case "XXE":
																									return btn9;
																									break;

																								case "XEX":
																									return btn8;
																									break;

																								case "EXX":
																									return btn7;
																									break;

																								default:
																									switch (strArray[0] + strArray[3] + strArray[6])//Col1
																									{
																										case "XXE":
																											return btn7;
																											break;

																										case "XEX":
																											return btn4;
																											break;

																										case "EXX":
																											return btn1;
																											break;

																										default:
																											switch (strArray[1] + strArray[4] + strArray[7])//Col2
																											{
																												case "XXE":
																													return btn8;
																													break;

																												case "XEX":
																													return btn5;
																													break;

																												case "EXX":
																													return btn2;
																													break;

																												default:
																													switch (strArray[2] + strArray[5] + strArray[8])//Col3
																													{
																														case "XXE":
																															return btn9;
																															break;

																														case "XEX":
																															return btn6;
																															break;

																														case "EXX":
																															return btn3;
																															break;

																														default:
																															switch (strArray[0] + strArray[4] + strArray[8])//Diag1
																															{
																																case "XXE":
																																	return btn9;
																																	break;

																																case "XEX":
																																	return btn5;
																																	break;

																																case "EXX":
																																	return btn1;
																																	break;

																																default:
																																	switch (strArray[2] + strArray[4] + strArray[6])//Diag2
																																	{
																																		case "XXE":
																																			return btn7;
																																			break;

																																		case "XEX":
																																			return btn5;
																																			break;

																																		case "EXX":
																																			return btn3;
																																			break;

																																		default:

																																			return OpponentPickNextAvailableBox();
																																			break;
																																	}
																																	break;
																															}
																															break;
																													}
																													break;
																											}
																											break;
																									}
																									break;
																							}
																							break;
																					}
																					break;
																			}
																			break;
																	}
																	break;
															}
															break;
													}
													break;
											}
											break;
									}
									break;
							}
							break;
					}
					break;
			}


			

		}


		public SinglePlayerPage()
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

				// A.I. Plays as "O", pick random box
				if (playerTurn != 0)
				{
					OpponentPickBox();
				}
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			btnReset.BackColor = Color.Salmon;
			btnReset.Location = new Point(62, 18);
			btnReset.Size = new Size(108, 41);
			if (alternateTurns == 0)
            {
				alternateTurns = 1;
				playerTurn = 1;
            }
            else
            {
				alternateTurns = 0;
				playerTurn = 0;
			}
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

			if (playerTurn != 0)
			{
				OpponentPickBox();
			}

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
