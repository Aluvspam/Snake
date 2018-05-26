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
        public List<Point> mySnake = new List<Point>();
        public Point food = new Point();
     
        public int maxX;
        public int maxY;
        public int Score { get; set; } // increment/decrement score when snake eats
        public  bool EndGame { get; set; }
        public  int Difficulty { get; set; }
        public  string PlayerName { get; set; }
        public  int Speed { get; set; }
        public  int Width { get; set; }
        public  int Height { get; set; }
        public  int Points { get; set; }//puncte scor
        public  Direction direction { get; set; }
        public GamePlay()
        {
            Points = 100;
            Score = 0;
            Width = 17;
            Height = 17;
            Speed = 5;
            PlayerName = "";
            Difficulty = 0;
            EndGame = false;
            direction = Direction.Right;
        }
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
            SnakeGame s = new SnakeGame();
            //s.MoveForward();
            //s.MoveBody();
        }
        public void Turn(Turns turnsTo)
        {
            SnakeGame s = new SnakeGame();
            //s.MoveBody();
            //s.MoveTurnHead(turnsTo);

        }
        #endregion

        #region SNAKE EATS 
        public void SnakeEat()
        {
            SnakeGame s = new SnakeGame();
            //s.Eat();
        }
        #endregion

    }
}

