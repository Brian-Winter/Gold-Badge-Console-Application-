using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe_Repo
{
    public class Menu
    {
        public string MealName { get; set; }
        public int MealNumber { get; set; }

        public string MealDescription { get; set; }

      //  public List<string> MealIngredientsList { get; set; } = new List<string>();

        public string Ingredients { get; set; }
        public decimal MealPrice { get; set; }



        public Menu() { }
        public Menu(string mealName, int mealNumber, string mealDescription, decimal mealPrice)
        {
            MealName = mealName;
            MealNumber = mealNumber;
            MealDescription = mealDescription;
          //  MealIngredients = mealIngredients;
            MealPrice = mealPrice;
        }
    }
}
