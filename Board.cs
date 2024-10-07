using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class Board
    {
        public List<Ball> Balls;
        public List<Board> Boards;

        public Board() 
        {
            Boards = new List<Board>();
        }

        public void Add(Ball balls)
        {
            Balls.Add(balls);
        }
    }
}
