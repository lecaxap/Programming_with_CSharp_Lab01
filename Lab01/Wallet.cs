using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Wallet
    {
        private enum CurrencyEnum {EUR, UAH, USD};

        private int id;
        private string name;
        private decimal balance;
        private string description;
        private CurrencyEnum currency;
        List<Category> categories;
        List<Transaction> transactions;

        public string Name { get => name; set => name = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public string Description { get => description; set => description = value; }
        public int Id { get => id; set => id = value; }
        private CurrencyEnum Currency { get => currency; set => currency = value; }

        public Wallet(int id, string name, decimal balance, string description)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.description = description;
            categories = new List<Category>();
            transactions = new List<Transaction>();

            Console.WriteLine("Please choose currency for this wallet. EUR - 1, UAH - 2, USD - 3");
            string currencyResponse = Console.ReadLine();
            while (currencyResponse != "1" || currencyResponse != "2" || currencyResponse != "3")
            {
                Console.WriteLine("Please choose currency for this wallet. EUR - 1, UAH - 2, USD - 3");
                currencyResponse = Console.ReadLine();
            }
            switch (currencyResponse)
            {
                case "1":
                    currency = CurrencyEnum.EUR;
                    break;
                case "2":
                    currency = CurrencyEnum.UAH;
                    break;
                case "3":
                    currency = CurrencyEnum.USD;
                    break;
            };
        }

        public void shareWallet() { }

        private void AddTransaction() { }

    }
}
