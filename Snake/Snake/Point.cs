using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
		private int v1;
		private int v2;

		public int X { get; set; }
        public int Y { get; set; }
        public static int Points { get; set; }

        public Point(int x, int y)
        {
            
            X = x;
            Y = y;
        }
        public Point()
        {
            Points = 100;
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }


    }
}
