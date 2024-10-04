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
            Circle one = new Circle  ("1", 2);
            Circle two = new Circle  ("2", 4);
            Circle three = new Circle("3", 6);
            Circle four = new Circle ("4", 8);
            Circle five = new Circle ("5", 10);

            double area1 = one.calcArea();
            double area2 = two.calcArea();
            double area3 = three.calcArea();
            double area4 = four.calcArea();
            double area5 = five.calcArea();

            double avg = (area1 + area2 +  area3 + area4 + area5)/5;
            Console.WriteLine(avg);

            Console.ReadLine();
        }
    }
}
