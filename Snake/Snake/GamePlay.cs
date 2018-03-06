using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public abstract class GamePlay
    {
        public DateTime Speed;
        public int GrowLength;
        public string Wall;
        public Point point;//use of point
        public Snake snake;
#region SNAKE MOTION
        public void TurnRight()
        {
            Snake s = new Snake();
            s.TurnRight();
        }
        public void TurnLeft()
        {
            Snake s = new Snake();
            s.TurnLeft();
        }
        public void MoveForward()
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
        public GamePlay(DateTime speed, string wall)
        {
            Speed = speed;
            Wall = wall;
        }

        public abstract void Move();
        public abstract void Controls();
        public abstract void StartGame();
        public abstract void EndGame();   
    }
}
