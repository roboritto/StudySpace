using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class SalesTransaction
    {
        public string SalespersonName { get; set; }
        public float TransactionValue { get; set; }
        public DateTime TransactionDate { get; set; }
        public SalesTransaction(string name, float value)
        {
            SalespersonName = name;
            TransactionValue = value;
            TransactionDate = DateTime.Now;
        }

        internal void Add(SalesTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
