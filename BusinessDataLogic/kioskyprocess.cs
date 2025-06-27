using System.Collections.Generic;
using DataLogicc;
using Common;

namespace BusinessDataLogic
{
    public class OrderService
    {
        public List<Meal> Meals;
        public List<Meal> Order;

        private IMealDataService dataService;
        public OrderService(IMealDataService dataService)
        {
            this.dataService = dataService;
            Meals = dataService.GetAllMeals();
            Order = new List<Meal>();
        }

        public List<Meal> GetMealsByCategory(string category)
        {
            List<Meal> result = new List<Meal>();
            foreach (Meal meal in Meals)
            {
                if (meal.Menus.Equals(category, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(meal);
                }
            }
            return result;
        }

        public string AddToOrder(int id)
        {
            foreach (Meal meal in Meals)
            {
                if (meal.Id == id)
                {
                    Order.Add(meal);
                    (dataService as DBMealDataService)?.SaveOrder(meal, meal.ServiceType);
                    return "Added: " + meal.Name;
                }
            }
            return "Meal not available.";
        }

        public string RemoveFromOrder(int index)
        {
            if (index >= 0 && index < Order.Count)
            {
                string name = Order[index].Name;
                Order.RemoveAt(index);
                return "Removed: " + name;
            }
            return "Invalid index.";
        }

        public string GenerateReceipt(string serviceType)
        {
            string receipt = "\nMcdollibee Receipt\n";
            receipt += "Service: " + serviceType + "\n";
            receipt += "Items:\n";
            int total = 0;
            foreach (Meal meal in Order)
            {
                receipt += "- " + meal.Name + " - P" + meal.Price + "\n";
                total += meal.Price;
            }
            receipt += "Total: P" + total + "\n";
            receipt += "Thank you! See us Again!\n";
            return receipt;
        }
        public void SaveOrderDetails(string filename, string serviceType)
        {
            List<string> lines = new List<string>();
            lines.Add("Mcdollibee Order Details");
            lines.Add("Items Ordered:");

            int total = 0;
            int count = 1;

            foreach (var meal in Order)
            {
                lines.Add($"{count}. {meal.Name} - P{meal.Price}");
                total += meal.Price;
                count++;
            }

            lines.Add("Total Price: P" + total);
            lines.Add("Service Type: " + serviceType);
            lines.Add("Thank you for your order!");

            System.IO.File.AppendAllLines(filename, lines);

        }

    }
}
