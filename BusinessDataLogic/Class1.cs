using System;
using System.Collections.Generic;

namespace kios101
{
    class MenuItem
    {
        public int Id { get; }
        public string Name { get; }
        public int Price { get; }

        public MenuItem(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

    class OrderService
    {
        private readonly List<MenuItem> menu = new List<MenuItem>
        {
            new MenuItem(1, "Cheese Burgir", 50),
            new MenuItem(2, "Fries", 40),
            new MenuItem(3, "Sundae", 35),
            new MenuItem(4, "JollyPares", 100)
        };

        public List<MenuItem> GetMenu()
        {
            return menu;
        }

        public string ProcessOrder(string choice)
        {
            if (int.TryParse(choice, out int orderId))
            {
                var item = menu.Find(m => m.Id == orderId);
                if (item != null)
                {
                    return item.Name;
                }
            }
            Console.WriteLine("Invalid Input! Please choose [1-4] only.");
            return null;
        }

        public string GenerateReceipt(List<string> currentOrder, string serviceChoice)
        {
            int totalAmount = 0;
            string receipt = "\n Mcdollibee Receipt \n";
            receipt += $"Service: {serviceChoice}\n";
            receipt += "Ordered Items:\n";

            foreach (string item in currentOrder)
            {
                int price = GetItemPrice(item);
                receipt += $"{item} - P{price}\n";
                totalAmount += price;
            }
            receipt += $"Total: P{totalAmount}\n";
            receipt += "--- Thank you for your order! ---\n";
            return receipt;
        }

        private int GetItemPrice(string itemName)
        {
            var item = menu.Find(m => m.Name == itemName);
            return item?.Price ?? 0;
        }
    }
}
