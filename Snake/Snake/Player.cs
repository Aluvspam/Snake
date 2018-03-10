using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	public class Player
	{
		public string playerName;
		public int highScore;
		public DateTime highScoreDate;

		public string PlayerName(string pName)
		{
			pName = Console.ReadLine();
			return pName;
		}
	}
}
