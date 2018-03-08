using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class SeeMyScore
    {
        int score = 0;
        public int GetScore()
        {
            return score;
        }
        public void AddPoint()
        {
            score++;
        }
        public void ResetScore()
        {
            score = 0;
        }

    }
}
