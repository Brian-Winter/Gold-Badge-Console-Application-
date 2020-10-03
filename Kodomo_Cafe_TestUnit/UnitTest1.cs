using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Komodo_Cafe_Repo;

namespace Kodomo_Cafe_TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        private Menu _testMenu = new Menu();
    
        private MenuRepository menuRepository = new MenuRepository();
        [TestMethod]
        public void AddTest()
        {
            Menu thirdItem = new Menu("Hot Dog", 3, "A juicy hot dog", "food", 1.50m);

            menuRepository.AddNewMenuItem(thirdItem);
            
        }

        [TestMethod]
        public void RemovalTest()
        {
            Menu thirdItem = new Menu("Hot Dog", 3, "A juicy hot dog", "food", 1.50m);
           //  menuRepository.AddNewMenuItem(thirdItem); Allows true statement

            Console.WriteLine(menuRepository.RemoveMenuItem("Hot Dog"));

            
        }
        [TestMethod]
        public void GetContentByNameTest()
        {
            Menu thirdItem = new Menu("Hot Dog", 3, "A juicy hot dog", "food", 1.50m);
            menuRepository.AddNewMenuItem(thirdItem);

            Console.WriteLine(menuRepository.GetContentbyName("hot dog").MealNumber);
        }
        [TestMethod]
        public void GetContentByNumberTest()
        {
            Menu thirdItem = new Menu("Hot Dog", 3, "A juicy hot dog", "food", 1.50m);
            menuRepository.AddNewMenuItem(thirdItem);

            Console.WriteLine(menuRepository.GetContentbyNumber(3).MealName);
        }
        [TestMethod]
        public void ViewAllTest()
        {
            Menu FirstItem = new Menu("CheeseBurger", 1, "Hamburger with a bun and cheese", "food", 2.52m);
            Menu secondItem = new Menu("HamBurger", 5, "Hamburger with a bun", "food", 2.25m);
            Menu thirdItem = new Menu("Hot Dog", 3, "A juicy hot dog", "food", 1.50m);


            menuRepository.AddNewMenuItem(FirstItem);
            menuRepository.AddNewMenuItem(secondItem);
            menuRepository.AddNewMenuItem(thirdItem);

            Console.WriteLine(menuRepository.ViewAllMenuItems()[0].MealNumber);
            Console.WriteLine(menuRepository.ViewAllMenuItems()[1].MealNumber);
            Console.WriteLine(menuRepository.ViewAllMenuItems()[2].MealNumber);
            Console.WriteLine("There are: " + menuRepository.ViewAllMenuItems().Count);
        }

    }
}
