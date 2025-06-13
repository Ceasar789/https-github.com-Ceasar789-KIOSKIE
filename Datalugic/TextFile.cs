using System;
using System.Collections.Generic;
using System.IO;
using Common;

namespace DataLogicc
{
    public class TextFileMealDataService : IMealDataService
    {
        string filePath = "meals.txt";
        List<Meal> meals;

        public TextFileMealDataService()
        {
            meals = new List<Meal>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    Meal meal = new Meal();
                    meal.Id = Convert.ToInt32(parts[0]);
                    meal.Name = parts[1];
                    meal.Price = Convert.ToInt32(parts[2]);
                    meal.Menus = parts[3];
                    meals.Add(meal);
                }
            }
        }

        public List<Meal> GetAllMeals()
        {
            return meals;
        }

        public void AddMeal(Meal meal)
        {
            meals.Add(meal);
            Save();
        }

        public void UpdateMeal(Meal meal)
        {
            for (int i = 0; i < meals.Count; i++)
            {
                if (meals[i].Id == meal.Id)
                {
                    meals[i] = meal;
                    break;
                }
            }
            Save();
        }

        public void RemoveMeal(int id)
        {
            for (int i = 0; i < meals.Count; i++)
            {
                if (meals[i].Id == id)
                {
                    meals.RemoveAt(i);
                    break;
                }
            }
            Save();
        }

        private void Save()
        {
            string[] lines = new string[meals.Count];
            for (int i = 0; i < meals.Count; i++)
            {
                lines[i] = meals[i].Id + "|" + meals[i].Name + "|" + meals[i].Price + "|" + meals[i].Menus;
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}




