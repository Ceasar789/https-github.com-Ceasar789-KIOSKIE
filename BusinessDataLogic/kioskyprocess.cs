using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDataLogic
{
    public class kiosdata
    {
        public static string ProcessOrder(string usrchoice, List<string> currentOrder)
        {
            switch (usrchoice)
            {
                case "1":
                    currentOrder.Add("Cheese Burgir");
                    return "Cheese Burgir Added!";
                    break;
                case "2":
                    currentOrder.Add("Fries");
                    return "Fries Added!";
                    break;
                case "3":
                    currentOrder.Add("Sundae");
                    return "Sundae Added!";
                    break;
                case "4":
                    currentOrder.Add("JollyPares");
                    return "JollyPares Added!";
                    break;
                default:
                    return "Invalid Input. Please press [1-4] to order.";
                    break;
            }
        }

        public static string RemoveItemFromOrder(List<string> currentOrder)
        {
            if (currentOrder.Count == 0)
            {
                return "Your order cart is empty.";
            }

            return "Choose your order by pressing numbers [1-4], or press [0] to exit.\nPress [5] to remove item from your order cart.";
            for (int i = 0; i < currentOrder.Count; i++)
            {
                return $"{i + 1}. {currentOrder[i]}";
            }

            return "Press [0] to cancel.";
            string removeChoice = Console.ReadLine();

            if (removeChoice == "0")
            {
                return "Cancelled.";
            }

            int itemIndex;
            if (int.TryParse(removeChoice, out itemIndex) && itemIndex >= 1 && itemIndex <= currentOrder.Count)
            {
                string removedItem = currentOrder[itemIndex - 1];
                currentOrder.RemoveAt(itemIndex - 1);
                return "Item removed.";
            }
            else
            {
                return "Invalid Input. Please choose [1-4] only.";
            }
        }

        public static string GenerateReceipt(List<string> currentOrder, string serviceChoice)
        {
            int totalAmount = 0;
            string receipt = " Mcdollibee Receipt ";
            receipt += $"Service: {serviceChoice}";
            receipt += "Ordered Items:\n";

            foreach (string item in currentOrder)
            {
                receipt += $"{item}\n";
                totalAmount += GetItemPrice(item);
            }
            receipt += $"Total: P{totalAmount}\n";
            receipt += "Thank you for your order! \n";
            receipt += "Mcdollibee Binan.\n";
            return receipt;
        }
        public static int GetItemPrice(string item)
        {
            switch (item)
            {
                case "Cheese Burgir":
                    return 50;
                case "Fries":
                    return 40;
                case "Sundae":
                    return 35;
                case "JollyPares":
                    return 100;
                default:
                    return 0;
            }
        }
    }
}