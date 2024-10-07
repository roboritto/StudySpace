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
            SalesTransaction ad = new SalesTransaction("Adlin", 100);
            SalesTransaction li = new SalesTransaction("Aliya", 90);
            Sales sales = new Sales();
            sales.Add(ad);
            sales.Add(li);

            Console.WriteLine(sales.Sum(ad));

            Console.ReadLine();
        }
    }
}
