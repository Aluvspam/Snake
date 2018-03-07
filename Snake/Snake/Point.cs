using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public int Width { get; set; } //ajutor in setarea obiectului sarpe, pozitie mancare, tabla de joc
        public int Height { get; set; }
        public bool EndGame { get; set; }// cat timp este fals jocul va continua
        public int X { get; set; }//locatia x si y a obiectului snake
        public int Y { get; set; }

        public Point(int x, int y)
        {
            Width = 0;//de setat valorile
            Height = 0;
            EndGame = false;
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
        public void Die()
        {
            EndGame = true;
        }

    }
}
