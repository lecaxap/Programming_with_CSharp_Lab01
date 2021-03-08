using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class ProgramTest
    {
        static int customerId = 1;
        static int walletId = 1;
        static int transactionId = 1;
        static int categoryId = 1;
        static List<Customer> customers = new List<Customer>();


        public static void createCustomer() {
            Console.WriteLine("Please type your name");
            string name = Console.ReadLine();
            while (name.Length < 1)
            {
                Console.WriteLine("Please type your name. It should contain something");
                name = Console.ReadLine();
            }

            Console.WriteLine("Please type your surname");
            string surname = Console.ReadLine();
            while (surname.Length < 1)
            {
                Console.WriteLine("Please type your surname. It should contain something");
                surname = Console.ReadLine();
            }

            Console.WriteLine("Please type your email");
            string email = Console.ReadLine();
            while (email.Length < 1)
            {
                Console.WriteLine("Please type your email. It should contain something");
                email = Console.ReadLine();
            }

            customers.Add(new Customer(customerId, name, surname, email));
            customerId++;
        }

         static void Main(string[] args) { 

            Console.WriteLine("Welcome to the best online expenses system ever! If you would like to start - press anything but 0.");
            string responseMain = Console.ReadLine();
            while (responseMain != "0") {
                Console.WriteLine("Would you like to proceed as an existing customer or create a new one for yourself?" +
                    " If you are new - press 1, if you would like to proceed - press 2.");
                string responseFirst = Console.ReadLine();
                while (responseFirst != "1" && responseFirst != "2") {
                    Console.WriteLine("Would you like to proceed as an existing customer or create a new one for yourself?" +
                    " If you are new - press 1, if you would like to proceed - press 2.");
                    responseFirst = Console.ReadLine();
                }
                switch (responseFirst) {
                    case "1":
                        createCustomer();
                        break;
                    case "2":
                        if (customers.Count < 1)
                        {
                            Console.WriteLine("No customers in the system. Please create one!");
                            createCustomer();
                        }
                        else {
                            Console.WriteLine("Choose a customer to proceed with.");
                            foreach (Customer c in customers) {
                                Console.WriteLine(c.ToString());
                            }
                            Console.WriteLine("Type the name and the surname of the chosen customer, separated by a space");
                            string response = Console.ReadLine();
                            string[] nameSurname = response.Split();
                            while (nameSurname.Length != 2) {
                                Console.WriteLine("Type the name and the surname of the chosen customer, separated by a space. You did it wrong");
                                response = Console.ReadLine();
                                nameSurname = response.Split();
                            }
                            
                        }
                        break;

                }
            }

        }

    }
}
