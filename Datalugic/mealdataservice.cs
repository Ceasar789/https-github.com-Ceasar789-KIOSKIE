using System.Collections.Generic;
using Common;

namespace DataLogicc
{
    public class MealDataService
    {
        public List<Meal> GetAllMeals()
        {
            List<Meal> meals = new List<Meal>();
            meals.Add(new Meal { Id = 1, Name = "Big Mac & Drinks", Price = 89, Menus = "Tipid" });
            meals.Add(new Meal { Id = 2, Name = "JollyHotdog & Drinks", Price = 79, Menus = "Tipid" });
            meals.Add(new Meal { Id = 3, Name = "Jolly Pares & Drinks", Price = 99, Menus = "Tipid" });
            meals.Add(new Meal { Id = 4, Name = "Jolly Pares Overload", Price = 199, Menus = "Super" });
            meals.Add(new Meal { Id = 5, Name = "2pcs Chicken & Spag", Price = 200, Menus = "Super" });
            meals.Add(new Meal { Id = 6, Name = "Whole Chicken Family Meal", Price = 499, Menus = "Secret" });
            meals.Add(new Meal { Id = 7, Name = "Customize Chicken", Price = 99, Menus = "Customize" });
            return meals;
        }
    }
}




