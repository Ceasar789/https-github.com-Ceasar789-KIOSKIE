using System;
using System.Collections.Generic;

namespace kios101
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            List<string> receiptHistory = new List<string>();

            ShowWelcomeMessage();

            int start;
            do
            {
                start = GetUserChoice();
                if (start == 1)
                {
                    List<string> currentOrder = new List<string>();
                    ShowMenu(orderService.GetMenu());

                    string usrchoice;
                    while ((usrchoice = GetUserChoiceForOrder()) != "0")
                    {
                        string itemAdded = orderService.ProcessOrder(usrchoice);
                        if (!string.IsNullOrEmpty(itemAdded))
                        {
                            currentOrder.Add(itemAdded);
                            Console.WriteLine($"{itemAdded} Added!");
                        }
                    }

                    string serviceChoice = GetServiceChoice();
                    string receipt = orderService.GenerateReceipt(currentOrder, serviceChoice);
                    receiptHistory.Add(receipt);

                    Console.WriteLine(receipt);
                    Console.WriteLine("Would you like to make another order? (Press [1] for Yes, [0] for No)");

                    if (!int.TryParse(Console.ReadLine(), out start) || (start != 0 && start != 1))
                    {
                        start = 0;
                    }
                }
            } while (start == 1);

            Console.WriteLine("Thank you for coming! See you again!");
        }

        static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to Mcdollibee Binan! Please press [1] to Order.");
        }

        static int GetUserChoice()
        {
            int choice;
            do
            {
                Console.WriteLine("Press [1] to start ordering.");
                if (!int.TryParse(Console.ReadLine(), out choice) || choice != 1)
                {
                    Console.WriteLine("Invalid Input. Please press [1] to start ordering.");
                }
            } while (choice != 1);
            return choice;
        }

        static void ShowMenu(List<Menu> menu)
        {
            Console.WriteLine("\nMcdollibee MENU:");
            foreach (var item in menu)
            {
                Console.WriteLine($"[{item.Id}] {item.Name} - P{item.Price}");
            }
        }

        static string GetUserChoiceForOrder()
        {
            Console.WriteLine("Choose your order by pressing numbers [1-4], or press [0] to finish your order.");
            return Console.ReadLine();
        }

        static string GetServiceChoice()
        {
            string serviceChoice;
            do
            {
                Console.WriteLine("Please choose your service type: [1] Dine-in or [2] Takeout");
                serviceChoice = Console.ReadLine();

                if (serviceChoice != "1" && serviceChoice != "2")
                {
                    Console.WriteLine("Invalid input! Please select [1] for Dine-in or [2] for Takeout.");
                }

            } while (serviceChoice != "1" && serviceChoice != "2");

            return serviceChoice == "1" ? "Dine-in" : "Takeout";
        }
    }

    class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class OrderService
    {
        private List<Menu> menu = new List<Menu>
        {
            new Menu { Id = 1, Name = " Cheese Burgir", Price = 45.0 },
            new Menu { Id = 2, Name = "Fries", Price = 35.0 },
            new Menu { Id = 3, Name = "Sundae", Price = 30.0 },
            new Menu { Id = 4, Name = "JollyPares", Price = 100.0 }
        };

        public List<Menu> GetMenu()
        {
            return menu;
        }

        public string ProcessOrder(string choice)
        {
            if (int.TryParse(choice, out int id))
            {
                Menu item = menu.Find(m => m.Id == id);
                return item != null ? item.Name : "";
            }
            return "";
        }

        public string GenerateReceipt(List<string> order, string serviceType)
        {
            return $"Receipt:\nItems: {string.Join(", ", order)}\nService: {serviceType}\nTotal: P{order.Count * 50}";
        }
    }
}