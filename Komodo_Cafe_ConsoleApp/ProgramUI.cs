using Komodo_Cafe_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe_ConsoleApp
{
    public class ProgramUI
    {
        private MenuRepository _contentOfMenuRepository = new MenuRepository();
        public void Run()
        {
            SeedContentList();
            Menu();
        }
        private void Menu()
        {

            bool isRunning = true;
            while (isRunning)
            {

                Console.Clear();
                Console.WriteLine("Please select an option:\n" +
                    "1. View Menu List\n" +
                    "2. Add Menu Item\n" +
                    "3. Remove Menu Item\n" +
                    "4. Exit Program");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //View Menu List
                        ViewMenuList();
                        break;
                    case "2":
                        //Add Menu Item
                        AddMenuItem();
                        break;
                    case "3":
                        // Remove Menu Item
                        RemoveMenuItem();
                        break;
                    case "4":
                        isRunning = false;
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;


                }
                Console.ReadKey();
                Console.Clear();
            }
        }


        private void ViewMenuList()
        {

            Console.Clear();
            List<Menu> listofMenuItems = _contentOfMenuRepository.ViewAllMenuItems();

            var sortedMenu = listofMenuItems.OrderBy(x => x.MealNumber)
                                            .ToList();

            foreach(Menu content in sortedMenu)
            {
                Console.WriteLine($"Meal Number: {content.MealNumber}\n" +
                    $"Menu Name: {content.MealName}\n" +
                    $"Meal Price: {content.MealPrice}\n" +
                    $"Meal Description: {content.MealDescription}\n" +
                    $"Meal Ingredients: {content.MealIngredientsList[0]}\n" +
                    $"");
            }


        }
        private void RemovalMenuList()
        {

            Console.Clear();
            List<Menu> listofMenuItems = _contentOfMenuRepository.ViewAllMenuItems();

            foreach (Menu content in listofMenuItems)
            {
                Console.WriteLine($"Menu Name: {content.MealName}");

            }

        }
        private void AddMenuItem() 
        {
            Console.Clear();
            Menu newItem = new Menu();
            
            //Name
            Console.WriteLine("Meal Name:");
            newItem.MealName = Console.ReadLine();
            //Number
            Console.WriteLine("MealNumber:");
            newItem.MealNumber = Convert.ToInt32(Console.ReadLine());
            //int newNumber = Convert.ToInt32(Console.ReadLine());
            //Menu checkContent = _contentOfMenuRepository.GetContentbyNumber(newNumber);
            //int content = Convert.ToInt32(checkContent);
            //if(newNumber == content)
            //{
            //    Console.WriteLine("Number is taken, please try again.");
            //}
            //else
            //{
            //    newItem.MealNumber = newNumber;
            //}
            //Description
            Console.WriteLine("Meal Description:");
            newItem.MealDescription = Console.ReadLine();
            //Ingredients
            Console.WriteLine("Meal Ingredients");
            string input = Console.ReadLine();
            newItem.MealIngredientsList.Add(input);
            //Price
            Console.WriteLine("Meal Price:");
            newItem.MealPrice = Convert.ToDecimal(Console.ReadLine());

            _contentOfMenuRepository.AddNewMenuItem(newItem);
        }
        private void RemoveMenuItem() 
        {
                RemovalMenuList();
                Console.WriteLine("\nPlease select which menu item you wish to remove.");

            string input = Console.ReadLine();

            bool wasRemoved = _contentOfMenuRepository.RemoveMenuItem(input);
            if (wasRemoved)
            {
                Console.WriteLine("The menu item has been removed.");

            }
            else
            {
                Console.WriteLine("Unable to remove menu item. Please try again.");
            }
        }

        //Test Menu Items
        public void SeedContentList()
        {
            Menu FirstItem = new Menu("CheeseBurger", 1, "Hamburger with a bun and cheese", "food", 2.52m);
            Menu secondItem = new Menu("HamBurger", 5, "Hamburger with a bun", "food", 2.25m);
            Menu thirdItem = new Menu("Hot Dog", 3, "A juicy hot dog", "food", 1.50m);


            _contentOfMenuRepository.AddNewMenuItem(FirstItem);
            _contentOfMenuRepository.AddNewMenuItem(secondItem);
            _contentOfMenuRepository.AddNewMenuItem(thirdItem);
        }
    }
}
