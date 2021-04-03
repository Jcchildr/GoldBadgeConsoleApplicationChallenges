using _4._00_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._00_Challenge_Console_App
{
    class Outings_MenuUI
    {
        private CompanyOutings _repo = new CompanyOutings();
        public void Run()
        {
            _repo.SeedMenu();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("----Welcome to the Komodo Company Outings manager----");
                Console.WriteLine("What would you like to do?\n" +
                    "1) Display all Outings\n" +
                    "2) Add a new Company Outing\n" +
                    "3) Take a peak at the numbers(cost of outings)\n" +
                    "4) Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayList();
                        break;
                    case "2":
                        AddOuting();
                        break;
                    case "3":
                        Calculations();
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

        public void DisplayList()
        {
            List<CompanyOutings_Content> _listOfEvents = _repo.ReturnEvents();
            Console.Clear();
            foreach(CompanyOutings_Content content in _listOfEvents)
            {
                Console.WriteLine($"Event Type: {content.EventType}\n" +
                        $"Total people attending: {content.NumberInAttendance}\n" +
                        $"Date of event: {content.DateOfEvent}\n" +
                        $"Cost per person: ${content.CostPerPerson}\n" +
                        $"Total Price: ${content.CostOfEvent}\n" +
                        "-------------------------");
            }
        }

        public void AddOuting()
        {
            Console.Clear();
            CompanyOutings_Content newOuting = new CompanyOutings_Content();
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Write("Enter the event type (Golf, Bowling, Amusement Park or Concert):  ");
                string type = Console.ReadLine();
                if (type == "Golf" || type == "Bowling" || type == "Amusement Park" || type == "Concert")
                {
                    newOuting.EventType = type;
                    keepRunning = false;
                }
                else
                {
                   
                    Console.WriteLine("Please enter a valid event type.");
                    
                }
            }
            Console.Write("Enter number of people attending:  ");
            string numberOfPeople = Console.ReadLine();
            newOuting.NumberInAttendance = int.Parse(numberOfPeople);
            int numberOfPeopleInt = int.Parse(numberOfPeople);

            Console.Write("Enter the date of the event: ");
            newOuting.DateOfEvent = Console.ReadLine();

            Console.Write("Enter cost per person: ");
            string costPerPerson = Console.ReadLine();
            newOuting.CostPerPerson = double.Parse(costPerPerson);
            double costPerPersonInt = double.Parse(costPerPerson);

            newOuting.CostOfEvent = (costPerPersonInt * numberOfPeopleInt);
            _repo.AddContentToList(newOuting);
        }

        public void Calculations()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("----Calculation Menu----");
                Console.WriteLine("What would you like to do?\n" +
                    "1) Display total cost of all outings\n" +
                    "2) Display cost baised on type of outing\n" +
                    "3) Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplaySumCost();
                        break;
                    case "2":
                        DisplayCostPerItem();
                        break;
                    case "3":
                        Console.WriteLine("Returning to main menu..");
                        keepRunning = false;
                        break;     
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.ReadLine();
            }
        }

        public void DisplaySumCost()
        {
            Console.Clear();
            double totalAmount = _repo.ReturnSum();
            Console.WriteLine("The total cost for all outings is $" + $"{totalAmount}" +"\n");
        }
        public void DisplayCostPerItem()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Write("Enter the event type (Golf, Bowling, Amusement Park or Concert):  ");
                string type = Console.ReadLine();
                if (type == "Golf")
                {
                    double outingTypeSum = _repo.ReturnGolfItemCost();
                    Console.Clear();
                    Console.WriteLine("The total cost for all Golf outings is $" + $"{outingTypeSum}" + "\n");
                    keepRunning = false;
                }
                else if (type == "Bowling")
                {
                    double outingTypeSum = _repo.ReturnBowlingItemCost();
                    Console.Clear();
                    Console.WriteLine("The total cost for all Bowling outings is $" + $"{outingTypeSum}" + "\n");
                    keepRunning = false;
                }
                else if (type == "Amusement Park")
                {
                    double outingTypeSum = _repo.ReturnAmusementParkItemCost();
                    Console.Clear();
                    Console.WriteLine("The total cost for all Amusement Park outings is $" + $"{outingTypeSum}" + "\n");
                    keepRunning = false;
                }
                else if (type == "Concert")
                {
                    double outingTypeSum = _repo.ReturnConcertItemCost();
                    Console.Clear();
                    Console.WriteLine("The total cost for all Concert outings is $" + $"{outingTypeSum}" + "\n");
                    keepRunning = false;
                }
                else
                {
                  Console.WriteLine("Please enter a valid event type.");
                }
            }
        }
    }
}
