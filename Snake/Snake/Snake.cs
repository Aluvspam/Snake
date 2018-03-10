using Snake.Enums;
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

        public Directions Direction { get; set; }

        public Snake()
        {
            Length = 3;
            Life = 0;
        }

		//Daca nu e bine, dam cu delete :) (Luana)
		public void InitializeSnake()
		{
			//intialize snake AKA move forward - Snake length 3. (by Luana)
			for (int i = 0; i < Length; i++)
			{
				Body.Add(new Point(3, 2 + i));
			}
		}

        public void MoveForward()
        {
			throw new NotImplementedException();
        }
        public void MoveTurnHead(Turns turnsTo)
        {

        }
        public void MoveBody()
        {
			//Move Snake
			Point next = Body[0];
			Body.Insert(0, next);
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
