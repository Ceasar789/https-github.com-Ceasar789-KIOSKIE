using System.Collections.Generic;
using Common;

namespace DataLogicc
{
    public interface IMealDataService
    {
        List<Meal> GetAllMeals();
       public void AddMeal(Meal meal);
       public void UpdateMeal(Meal meal);
        public void RemoveMeal(int id);
    }
}


