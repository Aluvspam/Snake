﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {

        public int X { get; set; }//locatia x si y a obiectului snake
        public int Y { get; set; }
        public int Width { get; set; } //ajutor in setarea obiectului sarpe, localizare plasare food, dimensiuni tabla de joc
        public int Height { get; set; }
        public bool EndGame { get; set; }// cat timp este fals jocul va continua
       

        public Point(int width, int height, bool endgame, int x, int y)
        {
            Width = width;
            Height = height;
            EndGame = endgame;//false?
            X = x;
            Y = y;
        }

        public void Die()
        {
            EndGame = true;
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }


    }
}
