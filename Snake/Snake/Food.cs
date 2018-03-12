using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food
    {

        public Point location = new Point(1, 1);
        public Random random = new Random();

        public void SetRandomFoodLocation()
        {
            int X = random.Next(0, 25);
            int Y = random.Next(0, 25);
            location = new Point(X, Y);
        }

    }


}