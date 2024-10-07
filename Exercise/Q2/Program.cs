using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board game = new Board();

            Ball b = new Ball("GAMEBALL");
            Ball c = new Ball("GAMEBALL");
            game.Add(b);
            game.Add(c);

            b.move(1,2);
            c.move(2, 4);
        }
    }
}
