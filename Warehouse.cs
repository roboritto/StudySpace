using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class Warehouse : Product
    {
        public string Location { get; set; }
        public List<Product> Products { get; set; }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
        public Product FindProduct(Product product)
        {
            foreach (var item in Products)
            {
                if (product.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            } return null;
        }
    }
}
