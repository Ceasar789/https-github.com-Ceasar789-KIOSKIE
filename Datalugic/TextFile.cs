using System.Collections.Generic;
using System.IO;
using Common;

namespace DataLogicc
{
    public class TextFileMealDataService : IMealDataService
    {
        private string filePath = "meals.txt";
        private List<Meal> meals;

        public TextFileMealDataService()
        {
            meals = new List<Meal>();
            if (!File.Exists(filePath))
            {
                meals = GetDefaultMeals();
                Save();
            }
            else
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        meals.Add(new Meal
                        {
                            Id = int.Parse(parts[0]),
                            Name = parts[1],
                            Price = int.Parse(parts[2]),
                            Menus = parts[3]
                        });
                    }
                }
            }
        }

        public List<Meal> GetAllMeals() => meals;

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
            meals.RemoveAll(m => m.Id == id);
            Save();
        }

        private void Save()
        {
            List<string> lines = new();
            foreach (var meal in meals)
                lines.Add($"{meal.Id}|{meal.Name}|{meal.Price}|{meal.Menus}");
            File.WriteAllLines(filePath, lines);
        }

        private List<Meal> GetDefaultMeals()
        {
            return new List<Meal>
            {
                new Meal { Id = 1, Name = "Big Mac & Drinks", Price = 89, Menus = "Tipid" },
                new Meal { Id = 2, Name = "JollyHotdog & Drinks", Price = 79, Menus = "Tipid" },    
                new Meal { Id = 3, Name = "Jolly Pares & Drinks", Price = 99, Menus = "Tipid" },
                new Meal { Id = 4, Name = "Jolly Pares Overload", Price = 199, Menus = "Super" },
                new Meal { Id = 5, Name = "2pcs Chicken & Spag", Price = 200, Menus = "Super" },
                new Meal { Id = 6, Name = "Whole Chicken Family Meal", Price = 499, Menus = "Secret" },
                new Meal { Id = 7, Name = "Customize Chicken", Price = 99, Menus = "Customize" }
            };
        }
    }
}
