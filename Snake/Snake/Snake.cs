using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        #region fields & proprieties that will help us to build the snake

        private Rectangle[] snakeRec;
        public SolidBrush brush;
        //coordinates for snakeRec
        private int x, y, width, height;
        public Rectangle[] SnakeRec
        {
            get
            {
                return snakeRec;
            }
        }
        #endregion

        #region Makeing the Snake alive!
        public Snake()
        {
            snakeRec = new Rectangle[3];//the first appearance of the snake on the game
            brush = new SolidBrush(Color.Green);//the color of the snake
            //the rectangle dimensions:
            x = 20;
            y = 0;
            height = 10;
            width = 10;
            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }
        //we fill the paint rectangle with color
        public void PaintSnake(Graphics paper)
        {
            foreach (var item in snakeRec)
            {
                paper.FillRectangle(brush, item);
            }
        }
        public void PaintSnake()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)//WE START FROM THE BOTTOM TO THE TOP
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }
        #endregion

        #region SNAKE MOVES

        public void MoveDown()
        {
            PaintSnake();
            snakeRec[0].Y += 10;
        }
        public void MoveUp()
        {
            PaintSnake();
            snakeRec[0].Y -= 10;
        }
        public void MoveRight()
        {
            PaintSnake();
            snakeRec[0].X += 10;
        }
        public void MoveLeft()
        {
            PaintSnake();
            snakeRec[0].X -= 10;
        }
        #endregion

        #region GROW SNAKE

        public void GrowSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            snakeRec = rec.ToArray();
        }

        #endregion


        //   public Directions Direction { get; set; }


        //Daca nu e bine, dam cu delete :) (Luana)
        //public void InitializeSnake()
        //{
        //    //intialize snake AKA move forward - Snake length 3. (by Luana)
        //    for (int i = 0; i < Length; i++)
        //    {
        //        Body.Add(new Point(3, 2 + i));
        //    }
        //}
        //public void MoveForward()
        //{
        //    throw new NotImplementedException();
        //}
        //public void MoveTurnHead(Turns turnsTo)
        //{
        //    if (turnsTo == Turns.ClockWise)
        //    {
        //        //Direction++;
        //    }
        //}


    }
}
