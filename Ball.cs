using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class Ball
    {
        public string BallType { get; set; }
        public int x {  get; set; }
        public int y { get; set; }

        public Ball(string ballType) 
        {
            BallType = ballType;
        }

        public void move(int newx, int newy)
        {
            x = newx;
            y = newy;
        }

        public int getPosX(int x)
        {
            return x;
        }

        public int getPosY(int y)
        {
            return y;
        }

        public void getNumGameBall()
        {
            List<Ball> Balls = new List<Ball>();
        }
    }
}
