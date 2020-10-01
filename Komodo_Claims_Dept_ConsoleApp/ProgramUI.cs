using Komodo_Claims_Dept_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims_Dept_ConsoleApp
{
    class ProgramUI
    {

        
        private ClaimRepository _contentByClaim = new ClaimRepository();

        public void Run()
        {
            SeededClaims();
            Menu();
        }

        //Menu
        public void Menu()
        {
            Console.Clear();
            bool isRunning = true;
            while (isRunning)
            {

                Console.WriteLine("Please select an option:\n" +
                    "1. View All Claims\n" +
                    "2. Complete A Claim\n" +
                    "3. Create New Claim\n" +
                    "4. Exit Program");

                string input = Console.ReadLine();
                switch (input)
                {

                    case "1":
                        //View All Claims
                        ViewAllClaims();
                        break;
                    case "2":
                        //Complete Claims
                        RemoveCompletedClaim();
                        break;
                    case "3":
                        //Create a new claim
                        CreateNewClaim();
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

       // View All Claims
      
        public void ViewAllClaims()
        {
            Console.Clear();
            List<Claim> listofClaims = _contentByClaim.ViewAllClaims();

            var sortedList = listofClaims.OrderBy(x => x.ClaimID)
                                         .ToList();

            Console.WriteLine("{0,-8}|{1,-7}|{2,-30}|{3,-8}|{4,-14}|{5,-11}|{6,-7}", "Claim ID",  "Type", "Description",  "Amount", "DateOfAccident", "DateOfClaim", "IsValid");
            foreach (Claim content in sortedList)
            {
               
            Console.WriteLine($"{content.ClaimID, -8}|{content.TypeOfClaim, -7}|{content.Description,-30}|${content.ClaimAmount,-7}|" +
                    $"{content.DateOfIncident.ToString("MM/dd/yyyy"), -14}|{content.DateOfClaim.ToString("MM/dd/yyyy"),-11}|{content.IsValid,-7}");

            }
        }

      //  Complete Claim
        public void RemoveCompletedClaim()
        {

            List<Claim> listofClaims = _contentByClaim.ViewAllClaims();

            var sortedList = new Queue<Claim>(listofClaims);
            int i = 0;
            bool isTrue = true;
            while (isTrue)
            {
                Console.Clear();
                Console.WriteLine($"Claim ID : {sortedList.Peek().ClaimID} ");
                Console.WriteLine($"Type : {sortedList.Peek().TypeOfClaim} ");
                Console.WriteLine($"Description : {sortedList.Peek().Description} ");
                Console.WriteLine($"Amount : {sortedList.Peek().ClaimAmount} ");
                Console.WriteLine($"DateOfAccident : {sortedList.Peek().DateOfIncident} ");
                Console.WriteLine($"DateOfClaim : {sortedList.Peek().DateOfClaim} ");
                Console.WriteLine($"IsValid : {sortedList.Peek().IsValid} ");
                Console.WriteLine("");

                Console.WriteLine("Do you want to deal with this claim now(y/n)?");

                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "y":
                        sortedList.Dequeue();

                        break;
                    case "n":
                        Console.WriteLine("Returning to Main Menu.\n" +
                            "Press any key to continue...");
                        isTrue = false;
                        return;

                    default:
                        Console.WriteLine("Please enter valid option.");
                        break;
                }
           

            }
           

        }
        // Create a New Claim
        public void CreateNewClaim()
        {
            Console.Clear();
            Claim newContent = new Claim();

            //Claim ID
            Console.WriteLine("Please enter Claim ID.");
            newContent.ClaimID = Convert.ToInt32(Console.ReadLine());
            // Type
            Console.WriteLine("Please enter the type incident.\n" +
                "1.Car\n" +
                "2.Theft\n" +
                "3.Home");

            int input = Convert.ToInt32(Console.ReadLine());

            newContent.TypeOfClaim = (ClaimType)input;
           
            //Description
            Console.WriteLine("Please enter details of incident.");
            newContent.Description = Console.ReadLine();
            //Amount
            Console.WriteLine("Estimated amount of claim?");
            newContent.ClaimAmount = Convert.ToDecimal(Console.ReadLine());
            //Date of Incident
            Console.WriteLine("Please enter the date of the incident (MM/DD/YYYY)");
            newContent.DateOfIncident = Convert.ToDateTime(Console.ReadLine());
            //Date of Claim
            Console.WriteLine("Please enter the date of the claim (MM/DD/YYYY)");
            newContent.DateOfClaim = Convert.ToDateTime(Console.ReadLine());
            //IsValid
            TimeSpan spanOfTime = newContent.DateOfClaim - newContent.DateOfIncident;
            int span = (int) spanOfTime.TotalDays;
            //Console.WriteLine(span);
            if(span <= 30)
            {
                Console.WriteLine("This claim is valid.");
                newContent.IsValid = true;
            }
            else
            {
                Console.WriteLine("This claim is outside its 30 day time period.");
                newContent.IsValid = false;
            }

            _contentByClaim.AddNewClaim(newContent);
        }
        

        
        //seed material
        public void SeededClaims()
        {
            Claim firstClaim = new Claim(1, ClaimType.Car, "Fender Bender", 5000, new DateTime(2020,09,21), new DateTime(2020, 09, 22), true);
            Claim sClaim = new Claim(2, ClaimType.Car, "Fender Bender", 5000, new DateTime(2020,09,21), new DateTime(2020, 09, 22), false);
            Claim tClaim = new Claim(3, ClaimType.Theft, "TV Stolen", 250, new DateTime(2020,09,21), new DateTime(2020, 09, 22), true);
            Claim fClaim = new Claim(4, ClaimType.Car, "T-Bone Passenger Side", 3500, new DateTime(2020,09,21), new DateTime(2020, 09, 22), true);

            _contentByClaim.AddNewClaim(firstClaim);
            _contentByClaim.AddNewClaim(sClaim);
            _contentByClaim.AddNewClaim(tClaim);
            _contentByClaim.AddNewClaim(fClaim);
        }
    }
}
