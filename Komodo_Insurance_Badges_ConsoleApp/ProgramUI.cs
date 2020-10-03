using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo_Insurance_Badges_Repository;

namespace Komodo_Insurance_Badges_ConsoleApp
{
    class ProgramUI
    {
        private BadgeRepository _contentOfBadgeRepo = new BadgeRepository();

        public void Run()
        {
            Menu();
        }

        public void Menu()
        {
            Console.Clear();
            bool isRunning = true;
            while (isRunning)
            {

                Console.WriteLine("Please select an option:\n" +
                    "1. Add a Badge\n" +
                    "2. Edit a Badge\n" +
                    "3. List all Badges\n" +
                    "4. Exit Program");

                string input = Console.ReadLine();
                switch (input)
                {

                    case "1":
                        //Add a badge
                        AddBadge();
                        break;
                    case "2":
                        //Edit a Badge
                        EditBadge();
                        break;
                    case "3":
                        //List all badges
                        ReadAllBadges();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            }

        }

            //Add a badge
        private void AddBadge()
        {
            Console.Clear();
            Console.WriteLine("What is the number of the badge?");
            int newBadgeNumber = Convert.ToInt32(Console.ReadLine());

            //Add reference to Badge class and assign number

            Console.WriteLine("List a door that it needs access to:");
            string doorAccess = Console.ReadLine();
             _contentOfBadgeRepo.AddNewBadge(newBadgeNumber, new Badge(newBadgeNumber, doorAccess));
            //Add reference to Dictionary to add door referenced to badge
            bool moreDoors = true;
            while (moreDoors)
            {
                Console.WriteLine("Any other doors? (y/n)");
                string anotherDoor = Console.ReadLine().ToLower();
                switch (anotherDoor)
                {
                    case "y":
                        //Add reference to dictionary to add door
                        EnterDoorNumber();
                        _contentOfBadgeRepo.AddDoorNumber(newBadgeNumber);
                        break;
                    case "n":
                        moreDoors = false;
                        return;
                    default:
                        Console.WriteLine("Please choose a valid option.");
                        break;
                }
                
            }
        }
            //Edit a Badge
        private void EditBadge()
        {
            Console.Clear();
            Console.WriteLine("What is the badge number to update?");
                   
            int editedBadge = Convert.ToInt32(Console.ReadLine());
            if (!_contentOfBadgeRepo.CheckIfKeyExists(editedBadge))
            {
                Console.WriteLine("Badge Number does not exist");
                return;
            }
            Console.WriteLine("What would you like to do?\n" +
                "1. Remove a door\n" +
                "2. Add a door\n" +
                "3. Return to Main Menu");

            string updateOption = Console.ReadLine();
            switch (updateOption)
            {
                case "1":
                    //Remove Door
                    
                    EnterDoorNumber();
                    _contentOfBadgeRepo.RemoveDoorNumber(editedBadge);
                    
                    break;
                case "2":
                    //Add a door
                    
                    EnterDoorNumber();
                    _contentOfBadgeRepo.AddDoorNumber(editedBadge);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;

            }

        }
    
        public void EnterDoorNumber()
        {
            Console.Clear();
            Console.WriteLine("Please enter door number");
        }

        //List all badges
        public void ReadAllBadges()
        {
           Dictionary<int, Badge> allBadges =  _contentOfBadgeRepo.ViewAllBadges();
            Console.Clear();
            Console.WriteLine("{0,-8}{1}", "Badge#", "Door Access");
          
            foreach (KeyValuePair<int, Badge> content in allBadges)
            {
                
                
               
                Console.WriteLine($"{content.Key,-8}{string.Join(", ", content.Value.DoorNames)}");
            }
        }
    }
}
