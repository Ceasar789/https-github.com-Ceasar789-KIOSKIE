using System;
using BusinessDataLogic;
using Common;
using System.Collections.Generic;

namespace fixedwmthds
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();

            Console.WriteLine("Welcome to Mcdollibee Binan!");
            Console.Write("Press [1] to start your order: ");
            string start = Console.ReadLine();

            if (start != "1")
            {
                Console.WriteLine("Exiting");
                return;
            }
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("\nChoose Meal Types:");
                Console.WriteLine("[1] TipidMeals");
                Console.WriteLine("[2] SuperMeals");
                Console.WriteLine("[3] SecretMeals");
                Console.WriteLine("[4] CustomizeMeals");
                Console.WriteLine("[5] View Order");
                Console.WriteLine("[6] Remove Order");
                Console.WriteLine("[0] Checkout");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    Console.Write("Service type [1] Dine-in | [2] Take-out: ");
                    string serviceType = Console.ReadLine();
                    if (serviceType == "1") serviceType = "Dine-in";
                    else serviceType = "Take-out";

                    Console.WriteLine(service.GenerateReceipt(serviceType));
                    menu = false;
                }
                else if (choice == "5")
                {
                    Console.WriteLine("\nYour Order:");
                    for (int i = 0; i < service.Order.Count; i++)
                    {
                        Console.WriteLine("[" + (i + 1) + "] " + service.Order[i].Name);
                    }
                }
                else if (choice == "6")
                {
                    Console.WriteLine("\nWhich order to remove?");
                    for (int i = 0; i < service.Order.Count; i++)
                    {
                        Console.WriteLine("[" + (i + 1) + "] " + service.Order[i].Name);
                    }
                    Console.Write("Enter number: ");
                    string remove = Console.ReadLine();
                    int index;
                    if (int.TryParse(remove, out index))
                    {
                        Console.WriteLine(service.RemoveFromOrder(index - 1));
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                else
                {
                    string menus = "";
                    if (choice == "1") menus = "Tipid";
                    else if (choice == "2") menus = "Super";
                    else if (choice == "3") menus = "Secret";
                    else if (choice == "4") menus = "Customize";
                    if (menus != "")
                    {
                        Console.WriteLine();
                        Console.WriteLine(menus + "Meals Meals:");
                        List<Meal> meals = service.GetMealsByCategory(menus);

                        for (int i = 0; i < meals.Count; i++)
                        {
                            Console.WriteLine("[" + meals[i].Id + "] " + meals[i].Name + " - P" + meals[i].Price);
                        }
                        Console.Write("Enter Choice : ");
                        string mealIdStr = Console.ReadLine();
                        int mealId;
                        if (int.TryParse(mealIdStr, out mealId))
                        {
                            Console.WriteLine(service.AddToOrder(mealId));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Meals.");
                    }
                }
            }
        }
    }
}






