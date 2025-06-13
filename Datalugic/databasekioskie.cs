using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Common;

namespace DataLogicc
{
    public class DBMealDataService : IMealDataService
    {
        static string connectionString =
            "";

        public List<Meal> GetAllMeals()
        {
            var meals = new List<Meal>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, Price, Menus FROM Meals";
                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Meal meal = new Meal
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToInt32(reader["Price"]),
                        Menus = reader["Menus"].ToString()
                    };
                    meals.Add(meal);
                }

                conn.Close();
            }

            return meals;
        }

        public void AddMeal(Meal meal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Meals (Id, Name, Price, Menus) VALUES (@Id, @Name, @Price, @Menus)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", meal.Id);
                cmd.Parameters.AddWithValue("@Name", meal.Name);
                cmd.Parameters.AddWithValue("@Price", meal.Price);
                cmd.Parameters.AddWithValue("@Menus", meal.Menus);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateMeal(Meal meal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Meals SET Name = @Name, Price = @Price, Menus = @Menus WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", meal.Id);
                cmd.Parameters.AddWithValue("@Name", meal.Name);
                cmd.Parameters.AddWithValue("@Price", meal.Price);
                cmd.Parameters.AddWithValue("@Menus", meal.Menus);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void RemoveMeal(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Meals WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
