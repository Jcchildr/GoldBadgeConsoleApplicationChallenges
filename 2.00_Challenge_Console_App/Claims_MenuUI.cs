using _2._00_Challange_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._00_Challenge_Console_App
{
    class Claims_MenuUI
    {
        private Claims_Repository _repo = new Claims_Repository();
        public void Run()
        {
            _repo.SeedClaimsList();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("----Hello, Welcome to Komodo Insurance Claims Department----");
                Console.WriteLine("What would you like to do?\n" +
                    "1) View all claims\n" +
                    "2) Take care of the next claim \n" +
                    "3) Enter a new claim\n" +
                    "4) Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2":
                        NextClaim();
                        break;
                    case "3":
                        EnterNewClaim();
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
        }

        public void ViewAllClaims()
        {
           
            Console.Clear();
            List<ClaimsContent> _listOfClaims = _repo.ReturnClaims();
            Console.WriteLine("ClaimID    Type     Description          Amount     Date of Accident      Date of Claim\n" +
                "-----------------------------------------------------------------------------------------------");
            foreach (ClaimsContent content in _listOfClaims)
            {
                Console.WriteLine($"{content.ClaimID}" + "     " +
                    $"{content.ClaimType}" + "     " +
                    $"{content.BriefDescription}" + "     " +
                    $"{content.ClaimAmount}" + "     " +
                    $"{content.DateOfIncident}" + "     " +
                    $"{content.DateOfClaim}"); 
            }
        }

        public void NextClaim()
        {
            Console.Clear();
            Queue<ClaimsContent> _queueOfClaims = _repo.ReturnQueue();
            foreach (var content in _queueOfClaims)
            {
                Console.WriteLine(content);
            }
        }

        public void EnterNewClaim()
        {
            Console.Clear();
        }
    }
}
