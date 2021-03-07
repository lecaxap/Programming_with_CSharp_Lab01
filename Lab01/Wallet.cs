﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public enum CurrencyEnum { EUR, UAH, USD };

    class Wallet
    {

        private int id;
        private string name;
        private decimal balance;
        private string description;
        private CurrencyEnum currency;
        List<Category> categories;
        List<Transaction> transactions;

        public decimal Balance { get => balance; set => balance = value; }

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

        private void AddTransaction(int id) {
            Console.WriteLine("Please type the sum of the transaction");
            decimal sumTransaction = 0;
            string sumResponse = Console.ReadLine();
            bool parsed = decimal.TryParse(sumResponse, out sumTransaction);
            while (!parsed)
            {
                Console.WriteLine("Please type the sum of the transaction as a number");
                sumResponse = Console.ReadLine();
            }

            balance = balance + sumTransaction;
      
            Console.WriteLine("Would you like to add a description? Type Y if yes or anything else if not");
            string responseDescription = Console.ReadLine();
            string descriptionTransaction = "";
            if (responseDescription == "Y")
            {
                Console.WriteLine("Please type the description");
                descriptionTransaction = Console.ReadLine();
            }

            transactions.Add(new Transaction(id, sumTransaction, descriptionTransaction));
        }

        public override string ToString()
        {
            switch (description)
            {
                case "":
                    return id + ": " + name + ", balance: " + balance + currency;
                default:
                    return id + ": " + name + ", balance: " + balance + currency + ", " + description;
            }
            
        }

        public decimal incomeMonth() {
            decimal sum = 0;
            foreach (Transaction t in transactions) {
                if (t.Date.Month>=DateTime.Now.Month-1)
                    if (t.Sum > 0) sum += t.Sum;
            }
            return sum;
        }

        public decimal expensesMonth()
        {
            decimal sum = 0;
            foreach (Transaction t in transactions)
            {
                if (t.Date.Month >= DateTime.Now.Month - 1)
                    if (t.Sum < 0) sum -= t.Sum;
            }
            return sum;
        }

        public void showTransactions(int index) {
            index=transactions.Count()-index;
            for (int i = index; i < index + 10; i++) {
                if (i < transactions.Count())
                    Console.WriteLine(transactions[i].ToString());
            }
        } 

    }
}
