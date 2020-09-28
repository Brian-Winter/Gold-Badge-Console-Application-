using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe_Repo
{
    public class MenuRepository
    {
        private List<Menu> _listOfMenuContent = new List<Menu>();

        //Create
        public void AddNewMenuItem(Menu newItem)
        {
            _listOfMenuContent.Add(newItem);

        }


        //Delete
        public bool RemoveMenuItem(string item)
        {

            Menu content = GetContentbyName(item);

            if (content == null)
            {
                return false;
            }
            int numberOfItems = _listOfMenuContent.Count;
            _listOfMenuContent.Remove(content);

            if (numberOfItems > _listOfMenuContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Read
        public List<Menu> ViewAllMenuItems()
        {
            return _listOfMenuContent;

        }

        //Method to find item to Delete
        public Menu GetContentbyName(string name)
        {
            foreach (Menu content in _listOfMenuContent)
            {
                if (content.MealName.ToLower() == name.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        public Menu GetContentbyNumber(int number)
        {
            foreach (Menu content in _listOfMenuContent)
            {
                if (content.MealNumber == number)
                {
                    return content;
                }
            }
            return null;
        }

    }
}
