using System.Collections.Generic;
using DataLogicc;
using Common;

namespace BusinessDataLogic
{
    public class OrderService
    {
        public List<Meal> Meals;
        public List<Meal> Order;

        public OrderService()
        {
            MealDataService dataService = new MealDataService();
            Meals = dataService.GetAllMeals();
            Order = new List<Meal>();
        }
        public List<Meal> GetMealsByCategory(string category)
        {
            List<Meal> result = new List<Meal>();
            foreach (Meal meal in Meals)
            {
                if (meal.Menus == category)
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
    }
}






