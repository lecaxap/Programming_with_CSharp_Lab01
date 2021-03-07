﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Customer
    {
        private int id;
        private string name;
        private string surname;
        private string email;
        private List<Wallet> wallets;
        private List<Category> category;

        public int Id { get => id;}

        public Customer(int id, string name, string surname, string email) {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            wallets = new List<Wallet>();
            category = new List<Category>();
        }

        public void addWallet(int id) {
            Console.WriteLine("Please type the name of the wallet");
            string nameWallet = Console.ReadLine();
            while (nameWallet.Length < 1) {
                Console.WriteLine("Please type the name of the wallet. It should contain something");
                nameWallet = Console.ReadLine();
            }

            Console.WriteLine("Please type the balance of the wallet");
            decimal balanceWallet = 0;
            string balanceResponse = Console.ReadLine();
            bool parsed = decimal.TryParse(balanceResponse, out balanceWallet);
            while (!parsed || balanceWallet<0)
            {
                Console.WriteLine("Please type a non-negative balance of the wallet");
                balanceResponse = Console.ReadLine();
            }

            Console.WriteLine("Would you like to add a description? Type Y if yes or anything else if not");
            string responseDescription = Console.ReadLine();
            string descriptionWallet = "";
            if (responseDescription=="Y")
            {
                Console.WriteLine("Please type the description");
                descriptionWallet = Console.ReadLine();
            }

            wallets.Add(new Wallet(id, nameWallet, balanceWallet, descriptionWallet));
        }

        
    }
}
