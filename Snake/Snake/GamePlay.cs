//using Snake.Enums;
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
        public static int Score { get; set; } // increment/decrement score when snake eats
        public static bool EndGame { get; set; }
        public static int Difficulty { get; set; }
        public static string PlayerName { get; set; }
        public static int Speed { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Points { get; set; }//puncte scor
        public static Direction direction { get; set; }
        public GamePlay()
        {
            Points = 100;
            Score = 0;
            Width = 20;
            Height = 20;
            Speed = 5;
            PlayerName = "";
            Difficulty = 0;
            EndGame = false;
            direction = Direction.Right;
        }


        // public DateTime Speed;
        public int GrowLength;
        public string Wall;
        // public Directions Direction { get { return mySnake.Direction; } }

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




        #region SNAKE MOTION
        public void MoveForward()
        {
            Snake s = new Snake();
            //s.MoveForward();
            //s.MoveBody();
        }
        public void Turn(Turns turnsTo)
        {
            Snake s = new Snake();
            //s.MoveBody();
            //s.MoveTurnHead(turnsTo);

        }
        #endregion

        #region SNAKE EATS 
        public void SnakeEat()
        {
            Snake s = new Snake();
            //s.Eat();
        }
        #endregion

    }
}

