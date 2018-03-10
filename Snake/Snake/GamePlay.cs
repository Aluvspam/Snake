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
        public DateTime Speed;
        public int GrowLength;
        public string Wall;
        public int score; // increment/decrement score when snake eats
        public Snake snake;
       // public int Direction { get { return snake.Direction}}
        private static GamePlay instance;
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
            s.MoveForward();
            s.MoveBody();
        }
        public void Turn(Turns turnsTo)
        {
            Snake s = new Snake();
            s.MoveForward();

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
