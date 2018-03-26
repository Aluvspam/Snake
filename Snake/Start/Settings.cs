using Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public class Settings
    {
        public static int Points { get; set; }
        public static bool EndGame { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static string PlayerName { get; set; }
        public static int difficulty { get; set; }
        public Settings()
        {
            PlayerName = "";
            Speed = 6;
            EndGame = false;
            Score = 0;
            difficulty = 0;
            Points = 100;
        }
    }
}
