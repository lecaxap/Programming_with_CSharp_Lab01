using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Wallet
    {
        private enum CurrencyEnum { EUR, UAH, USD};

        private int id;
        private string name;
        private decimal balance;
        private string description;
        private string currency;
        List<Category> categories;
        List<Transaction> transactions;

        public string Name { get => name; set => name = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public string Description { get => description; set => description = value; }
        public string Currency { get => currency; set => currency = value; }
        public int Id { get => id; set => id = value; }

        private void AddTransaction() { }
    }
}
