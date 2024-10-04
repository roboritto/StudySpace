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
            Product p = new Product();

            p.Name = "Table";
            p.CostPrice = 10;
            p.SalePrice = 12;
            float profit = p.CalcProfit();

            Warehouse warehouse = new Warehouse();
            warehouse.Location = "Sri Iskandar";
  
            Console.WriteLine(p.Name + " = " + profit + ", added to " + warehouse.Location);

            Product foundProduct = warehouse.FindProduct(p);
            if (foundProduct != null)
            {
                Console.WriteLine("Yeay");
            }
            else
            {
                Console.WriteLine("Aww");
            }

            Console.ReadKey();
        }
    }
}
