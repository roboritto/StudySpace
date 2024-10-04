using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class Car
    {
        public float Speed { get; set; }
        public BitVector32 Position { get; set; }
        public BitVector32 Direction { get; set; }

        public Car(float speed, BitVector32 position, BitVector32 direction) 
        {
            Speed = speed;
            Position = position;
            Direction = direction;
        }

        public void Move()
        {
            return;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Convert.ToString(Speed));
        }
    }
}
