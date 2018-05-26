using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class Food
    {
      public static void EatLogic()
        {
            Point circle = new Point//cresc sarpele
            {
                x = GamePlay.Instance.mySnake[GamePlay.Instance.mySnake.Count - 1].x,

                y = GamePlay.Instance.mySnake[GamePlay.Instance.mySnake.Count - 1].y
            };
            GamePlay.Instance.mySnake.Add(circle);//aduc mancarea

            
            GamePlay.Instance.Score += GamePlay.Instance.Points;
            
        }

        public static void PlaceFoodLogic() 
        {
            Random random = new Random();
            GamePlay.Instance.food = new Point { x = random.Next(0, GamePlay.Instance.maxX), y = random.Next(0, GamePlay.Instance.maxY) };

        }




        //public Point location = new Point(1, 1);
        //public Random random = new Random();

        //public void SetRandomFoodLocation()
        //{
        //    int X = random.Next(0, 25);
        //    int Y = random.Next(0, 25);
        //    location = new Point(X, Y);
        //}

    }


}