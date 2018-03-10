using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public int Length;
        public int Life;
        public Point Head;
        public List<Point> Body = new List<Point>();

        public enum Directions { ClockWise, CounterClockWise};

        public Snake()
        {
            Length = 3;
            Life = 0;
        }

        public Directions Move { get; set; }

        public void MoveForward()
        {
            throw new NotImplementedException();
        }

        public void TurnLeft()
        {
            throw new NotImplementedException();
        }

        public void TurnRight()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
