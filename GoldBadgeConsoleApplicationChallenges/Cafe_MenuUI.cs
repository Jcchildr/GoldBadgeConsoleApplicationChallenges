using System;
using Repository_App;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeConsoleApplicationChallenges
{
    class Cafe_MenuUI
    {
        private CafeMenuContent_Repository _repoCafeContent = new CafeMenuContent_Repository();
        public void Run()
        {
            _repoCafeContent.SeedMenuList();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("----Welcome to the Komodo Cafe Menu Interface----");
                Console.WriteLine("What would you like to do?\n" +
                    "1) Create new menu item\n" +
                    "2) Delete menu item\n" +
                    "3) Recieve the current list of menu items\n" +
                    "4) Exit");
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        AddMenuItem();
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;
                    case "3":
                        ReturnMenu();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                Console.Clear();

            }

             void AddMenuItem()
            {
                Console.Clear();
                CafeMenuContent newContent = new CafeMenuContent();
                //Meal Number
                Console.Write("Enter the meal number: ");
                string mealNumberString = Console.ReadLine();
                newContent.MealNumber = int.Parse(mealNumberString);

                //Meal Name
                Console.Write("Enter the meal name: ");
                newContent.MealName = Console.ReadLine();

                //Meal Description
                Console.Write("Enter the meal description: ");
                newContent.BriefDescription = Console.ReadLine();

                //List of Ingredients
                Console.Write("Enter the meal ingredients: ");
                newContent.ListOfIngredients = Console.ReadLine();

                //Meal Price
                Console.Write("Enter the meal price: ");
                string mealPriceString = Console.ReadLine();
                newContent.Price = double.Parse(mealPriceString);

                _repoCafeContent.AddContentToList(newContent);
            }
            void ReturnMenu()
            {
                List<CafeMenuContent> _listOfMenuItems = _repoCafeContent.ReturnMenu();
                Console.Clear();
                foreach (CafeMenuContent content in _listOfMenuItems)
                {
                    Console.WriteLine($"Meal Number: {content.MealNumber}\n" +
                        $"Title: {content.MealName}\n" +
                        $"Description: {content.BriefDescription}\n" +
                        $"Ingredients: {content.ListOfIngredients}\n" +
                        $"Price: ${content.Price}\n" +
                        "-------------------------");
                }
            }
            void  DeleteMenuItem()
            {
                ReturnMenu();
                Console.Write("Enter the name of the meal you would like to delete: ");
                string userInput = Console.ReadLine();
                bool deleted = _repoCafeContent.RemoveMenuItem(userInput);

                if (deleted)
                {
                    Console.WriteLine("The content was successfully deleted.");
                }
                else
                {
                    Console.WriteLine("The content could not be deleted. Try again.");
                }
            }
           
        }
       
    }
}
