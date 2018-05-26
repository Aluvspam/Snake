using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class SnakeGame
    {

        public static void MoveBodyLogic()
        {
            for (int i = GamePlay.Instance.mySnake.Count - 1; i >= 0; i--)//mutare punct cu punct, cap+corp
            {//daca capul este activ
                if (i == 0)
                {
                    switch (GamePlay.Instance.direction)//mut fiecare parte a corpului, cf directiei data de cap
                    {
                        case Direction.Right:
                            GamePlay.Instance.mySnake[i].x++;//punctul curent din sarpe
                            break;
                        case Direction.Left:
                            GamePlay.Instance.mySnake[i].x--;
                            break;
                        case Direction.Up:
                            GamePlay.Instance.mySnake[i].y--;
                            break;
                        case Direction.Down:
                            GamePlay.Instance.mySnake[i].y++;
                            break;

                    }
                    //limitez sarpele la screen, spatiul de joc
                    //GamePlay.Instance.maxX = screen.Size.Width / GamePlay.Instance.Width;//pozitia max x si y
                    //GamePlay.Instance.maxY = screen.Size.Height / GamePlay.Instance.Height;
                    if (GamePlay.Instance.mySnake[i].x< 0 || GamePlay.Instance.mySnake[i].y< 0
                        || GamePlay.Instance.mySnake[i].x >= GamePlay.Instance.maxX || GamePlay.Instance.mySnake[i].y >= GamePlay.Instance.maxY)

                    {//la fiecare coleziune cu peretii, die
                        SnakeGame.Die();
                    }
                    for (int j = 1; j<GamePlay.Instance.mySnake.Count; j++)//coleziunea cu corpul
                    {
                        if (GamePlay.Instance.mySnake[i].x == GamePlay.Instance.mySnake[j].x &&
                             GamePlay.Instance.mySnake[i].y == GamePlay.Instance.mySnake[j].y)
                        {

                            SnakeGame.Die();
                        }
                    }

                    //detecteaza coleziunea cu mancarea
                    if (GamePlay.Instance.mySnake[0].x == GamePlay.Instance.food.x && GamePlay.Instance.mySnake[0].y == GamePlay.Instance.food.y)
                    {
                        Food.EatLogic();


                    }
                }
                else
                {
                    //daca nu apare niciun obstacol, Move body
                    GamePlay.Instance.mySnake[i].x = GamePlay.Instance.mySnake[i - 1].x;//muta urmatorul cerc conform cercului de dinainte, va apara ca sarpele se afla intr-o miscare continua
                    GamePlay.Instance.mySnake[i].y = GamePlay.Instance.mySnake[i - 1].y;
                }
            }
        }











        public static void Die()
        {
            GamePlay.Instance.EndGame = true;
        }





        //public int Length;
        //public int Life;
        //public Point Head;
        //public List<Point> Body = new List<Point>();

        //public Direction Direction { get; set; }

        //public Snake()
        //{
        //    Length = 3;
        //    Life = 0;
        //}

        ////Daca nu e bine, dam cu delete :) (Luana)
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
        //        Direction++;
        //    }
        //}
        //public void MoveBody()
        //{
        //    //Move Snake
        //    Point next = Body[0];
        //    Body.Insert(0, next);//TO DO: check if this method moves body as intender or grows body by 1 piece
        //}
        //public void Eat()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Grow()
        //{
        //    var aux = new Point(Body[Body.Count - 1].x, Body[Body.Count - 1].y);
        //    MoveForward();
        //    Body.Add(aux);
        //}
    }
}
