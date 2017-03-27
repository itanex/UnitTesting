using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BankAccount
    {
        private IList<Transaction> transactions;

        public int AccountNumber { get; private set; }
        public int RoutingNumber { get; private set; }

        public decimal Balance
        {
            get
            {
                return transactions.Sum(x => x.Value);
            }
        }

        public BankAccount(int accountNumber, int routingNumber)
        {
            AccountNumber = accountNumber;
            RoutingNumber = routingNumber;

            transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> GetTransactionList()
        {
            return transactions;
        }

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }
    }
}
