using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Common;

namespace DataLogicc
{
    public class JsonMealDataService : IMealDataService
    {
        private static string jsonFilePath = "meals.json";
        private static List<Meal> meals = new List<Meal>();

        public JsonMealDataService()
        {
            if (File.Exists(jsonFilePath))
            {
                string jsonText = File.ReadAllText(jsonFilePath);
                meals = JsonSerializer.Deserialize<List<Meal>>(jsonText);
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
            string json = JsonSerializer.Serialize(meals);
            File.WriteAllText(jsonFilePath, json);
        }
    }
}




