using System;
using System.Collections.Generic;
using System.IO;
using Common;

namespace BusinessDataLogic
{
    public class TextFileMealDataService
    {
        string filePath = "";
        public List<Meal> Meals;
        public List<Meal> Order;

        public TextFileMealDataService()
        {
            Meals = new List<Meal>();
            Order = new List<Meal>();
            LoadMealsFromFile();
        }

        private void LoadMealsFromFile()
        {
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                Meals.Add(new Meal
                {
                    Id = Convert.ToInt32(parts[0]),
                    Name = parts[1],
                    Price = Convert.ToInt32(parts[2]),
                    Menus = parts[3]
                });
            }
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

        public void SaveMealsToFile()
        {
            var lines = new string[Meals.Count];

            for (int i = 0; i < Meals.Count; i++)
            {
                lines[i] = $"{Meals[i].Id}|{Meals[i].Name}|{Meals[i].Price}|{Meals[i].Menus}";
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}

