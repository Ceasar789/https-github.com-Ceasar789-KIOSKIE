using System.Collections.Generic;
using Common;

namespace DataLogicc
{
    public class InMemoryMealDataService
    {
        private static List<Meal> _meals;

        static InMemoryMealDataService()
        {
            _meals = new List<Meal>
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

        public List<Meal> GetAllMeals()
        {
            return _meals;
        }
    }
}

