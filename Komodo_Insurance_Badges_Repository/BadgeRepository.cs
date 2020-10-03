using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Badges_Repository
{
    public class BadgeRepository
    {
       
                                                                    
        private Badge CreateBadges = new Badge();

        Dictionary<int, Badge> Badges = new Dictionary<int, Badge>();
            
        
        public void AddNewBadge(int badgeId, Badge badge)
        {
            
            Badges.Add(badgeId, badge);
        }
      

        public Dictionary<int, Badge> ViewAllBadges()
        {
            return Badges;
        }

        public void AddDoorNumber(int dictKey)
        {

            string newDoorNumber = Console.ReadLine();
            Badges[dictKey].DoorNames.Add(newDoorNumber);
            Console.WriteLine("Door has been added.");
        }

        public void RemoveDoorNumber(int dictKey)
        {

            string newDoorNumber = Console.ReadLine();
            Badges[dictKey].DoorNames.Remove(newDoorNumber);
            Console.WriteLine("Door has been removed.");
        }

       
        public bool CheckIfKeyExists(int key)
        {
            bool doesExists = Badges.ContainsKey(key);
            if (!doesExists)
            {
               
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ReadAllBadges()
        {
            Dictionary<int, Badge> allBadges = ViewAllBadges();
            Console.Clear();
            Console.WriteLine("{0,-8}{1}", "Badge#", "Door Access");

            foreach (KeyValuePair<int, Badge> content in allBadges)
            {



                Console.WriteLine($"{content.Key,-8}{string.Join(", ", content.Value.DoorNames)}");
            }
        }
        public void DisplayDoorAccess(int key)
        {
            foreach(KeyValuePair<int, Badge> kvp in Badges)
            {
                Console.WriteLine($"Badge: {key}, has access to doors {string.Join(", ",kvp.Value.DoorNames)}");
            }
        }

    }
}
