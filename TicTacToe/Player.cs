using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	public class Player
	{
		// X's or O's
		public string team { get; set; }
		public string enemy { get; set; }

		//used to keep track of players move before pressing submit(by butten.name), in the case that the player
		//wants to switch positions the old position will be cleared out.
		public string currentMove { get; set; }

	   


		public Player(string team, string enemy)
		{
			this.team = team;
			this.enemy = enemy;
			currentMove = " ";
		}



	}
}
