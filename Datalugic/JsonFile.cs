using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Common;

namespace DataLogicc
{
    public class JsonMealDataService
    {
        private static string jsonFilePath = "meals.json";
        private static List<Meal> meals = new List<Meal>();

        public JsonMealDataService()
        {
            ReadJsonDataFromFile();
        }

        private void ReadJsonDataFromFile()
        {
            if (File.Exists(jsonFilePath))
            {
                string jsonText = File.ReadAllText(jsonFilePath);
                meals = JsonSerializer.Deserialize<List<Meal>>(jsonText, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }

        private void WriteJsonDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(meals, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(jsonFilePath, jsonString);
        }

        public List<Meal> GetMeals()
        {
            return meals;
        }

        public void AddMeal(Meal meal)
        {
            meals.Add(meal);
            WriteJsonDataToFile();
        }

        public void RemoveMeal(int id)
        {
            meals.RemoveAll(m => m.Id == id);
            WriteJsonDataToFile();
        }

        public void UpdateMeal(Meal updatedMeal)
        {
            for (int i = 0; i < meals.Count; i++)
            {
                if (meals[i].Id == updatedMeal.Id)
                {
                    meals[i] = updatedMeal;
                    break;
                }
            }
            WriteJsonDataToFile();
        }
    }
}

