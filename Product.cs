using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class Product
    {
        public string Name { get; set; }
        public float CostPrice { get; set; }
        public float SalePrice { get; set; }

        public float CalcProfit ()
        {
            return SalePrice - CostPrice;
        }
        public Guid GetID()
        {
            return Guid.NewGuid();
        }
    }
}
