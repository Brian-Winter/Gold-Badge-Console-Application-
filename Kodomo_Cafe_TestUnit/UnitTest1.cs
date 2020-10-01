using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Komodo_Cafe_Repo;

namespace Kodomo_Cafe_TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        private Menu _testMenu = new Menu();
        private List<Menu> _testMenuProperties = new List<Menu>();
        private MenuRepository menuRepository = new MenuRepository();
        [TestMethod]
        public void TestMethod1()
        {
            Menu thirdItem = new Menu("Hot Dog", 3, "A juicy hot dog", "food", 1.50m);

            menuRepository.AddNewMenuItem(thirdItem);



           

            Console.WriteLine(menuRepository.GetContentbyName("hot dog"));

            Console.WriteLine(menuRepository.GetContentbyNumber(3));

            Console.WriteLine(menuRepository.RemoveMenuItem("hot dog"));
        }
          private void ViewMenuList()
        {

            Console.Clear();
            List<Menu> listofMenuItems = menuRepository.ViewAllMenuItems();

            var sortedMenu = listofMenuItems.OrderBy(x => x.MealNumber)
                                            .ToList();

            foreach(Menu content in sortedMenu)
            {
                Console.WriteLine($"Meal Number: {content.MealNumber}\n" +
                    $"Menu Name: {content.MealName}\n" +
                    $"Meal Price: {content.MealPrice}\n" +
                    $"Meal Description: {content.MealDescription}\n" +
                    $"Meal Ingredients: Unknown Please add\n" +
                    $"");
            }


        }
    }
}
