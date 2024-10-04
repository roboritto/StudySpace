using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class Circle : Color
    {
        public string ID { get; set; }
        public float Radius { get; set; }

        public Circle (string iD, float radius)
        {
            ID = iD;
            Radius = radius;
        }

        public double calcArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
