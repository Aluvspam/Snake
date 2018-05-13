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
            if (turnsTo == Turns.ClockWise)
            {
                Direction++;
            }
        }
        public void MoveBody()
        {
            //Move Snake
            Point next = Body[0];
            Body.Insert(0, next);//TO DO: check if this method moves body as intender or grows body by 1 piece
        }
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Grow()
        {
            var aux = new Point(Body[Body.Count - 1].x, Body[Body.Count - 1].y);
            MoveForward();
            Body.Add(aux);
        }
    }
}
