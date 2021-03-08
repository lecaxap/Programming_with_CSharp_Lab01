using System;
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
        private List<Category> categories;

        public int Id { get => id;}

        public Customer(int id, string name, string surname, string email) {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            wallets = new List<Wallet>();
            categories = new List<Category>();
        }

        public void createWallet(int id) {
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

            //визначення категорій гаманця
            Console.WriteLine("Which categories would you like to add to this wallet?");
            foreach (Category c in categories) {
                Console.WriteLine(c.Name);
            }
            Console.WriteLine("Type the name of category that you would like to add. Type 0 to stop");
            string responseCategory = Console.ReadLine();
            while (responseCategory != "0") {
                bool check = false;
                foreach (Category c in categories)
                {
                    if (c.Name == responseCategory)
                    {
                        if (!categories.Contains(c))
                        {
                            categories.Add(c);
                            check = true;
                        }
                    }
                }
                if (!check) Console.WriteLine("Such category doesn't exist or already added");
                Console.WriteLine("Type the name of category that you would like to add. Type 0 to stop");
                responseCategory = Console.ReadLine();
            }
        }

        //створення категорій для користувача
        public void createCategory(int id)
        {
            Console.WriteLine("Please type the name of the category");
            string nameCategory = Console.ReadLine();
            while (nameCategory.Length < 1)
            {
                Console.WriteLine("Please type the name of the category. It should contain something");
                nameCategory = Console.ReadLine();
            }

            Console.WriteLine("Would you like to add a description? Type Y if yes or anything else if not");
            string responseDescription = Console.ReadLine();
            string descriptionCategory = "";
            if (responseDescription == "Y")
            {
                Console.WriteLine("Please type the description");
                descriptionCategory = Console.ReadLine();
            }

            categories.Add (new Category(id, nameCategory, descriptionCategory));
        }

        public override string ToString()
        {
            return id+": "+name+" "+surname+", "+email;
        }

    }
}
