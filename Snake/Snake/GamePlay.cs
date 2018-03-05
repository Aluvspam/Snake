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

        public void TurnRight()
        {
            Snake S = new Snake();
           // S.TurnRight;
        }
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
