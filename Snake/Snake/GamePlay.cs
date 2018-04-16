using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GamePlay
    {
        public List<Point> mySnake = new List<Point>();

        public static bool EndGame { get; set; }
        public static int Difficulty { get; set; }
        public static string PlayerName { get; set; }
        public static int Speed { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Points { get; set; }//puncte scor
        public static Directions direction { get; set; }


        //public DateTime Speed;
        public int GrowLength;
        public string Wall;
        public static int Score { get; set; } // increment/decrement score when snake eats
        
        //public  Directions Direction { get { return mySnake.Direction; } }

        private static GamePlay instance;// exemplu de Singleton
       
        public static GamePlay Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GamePlay();
                }
                return instance;
            }
        }
        #region Constructor
        public GamePlay()
            {
            Points = 50;
            Score = 0;
            Width = 10;
            Height = 10;
            Speed = 6;
            PlayerName = "";
            Difficulty = 0;
            EndGame = false;
            direction = Directions.East;
        }
        #endregion

        #region SNAKE MOTION
        public void MoveForward()
        {
            Snake s = new Snake();
            s.MoveForward();
            s.MoveBody();
        }
        public void Turn(Turns turnsTo)
        {
            Snake s = new Snake();
            s.MoveBody();
            s.MoveTurnHead(turnsTo);

        }
        #endregion

        #region SNAKE EATS 
        public void SnakeEat()
        {
            Snake s = new Snake();
            s.Eat();
        }
        #endregion


    }
}
