using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Enums
{
    class Direction
    {
        public enum Directions { North, South, East, West };

        public Directions Move { get; set; }

    }
}
