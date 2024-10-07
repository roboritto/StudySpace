using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpace
{
    internal class Sales
    {
        private List<SalesTransaction> salesTransactions;

        public void Add(SalesTransaction transaction)
        {
            salesTransactions.Add(transaction);
        }

        public float Sum(SalesTransaction transaction)
        {
            float sum = 0;

            foreach (SalesTransaction s in salesTransactions)
            {
                sum += transaction.TransactionValue;
            }

            return sum;
        }
    }
}
