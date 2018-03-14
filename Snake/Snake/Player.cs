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

        static string _Name = " ";//by Dana, nu puteam accesa numele, daca il fixezi la tine, il sterg pe-al meu
        public static string Name
        {
            get
            {
                return Name;
            }
            set
            {
                _Name = value;
            }
        }
        static int _Difficulty = 0;
        public static int Difficulty
        {
            get
            {
                return Difficulty;
            }
            set
            {
                _Difficulty = value;
            }
        }


    }
}

