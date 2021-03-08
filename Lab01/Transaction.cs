using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Transaction
    {
        private int id;
        private decimal sum;
        private string description;
        private CurrencyEnum currency;
        private DateTime date;
        private string file;


        public Transaction(int id, decimal sum, string description) {
            this.id = id;
            this.sum = sum;
            this.description = description;
            date = DateTime.Now;
            
            //вибір валюти транзакції
            Console.WriteLine("Please choose currency for this transaction. EUR - 1, UAH - 2, USD - 3");
            string currencyResponse = Console.ReadLine();
            while (currencyResponse != "1" && currencyResponse != "2" && currencyResponse != "3")
            {
                Console.WriteLine("Please choose currency for this transaction. EUR - 1, UAH - 2, USD - 3");
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

        public decimal Sum { get => sum; set => sum = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Id { get => id;  }

        public override string ToString()
        {
            switch (description) {
                case "":
                    return id + ": sum - " + sum + currency+", "+date;
                default:
                    return id + ": sum - " + sum + currency + ", " + description + ", " + date;

            }
        }


    }
}
