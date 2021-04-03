using Badge_Repository_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._00_Challenge_Console_App
{
    class Badge_MenuUI
    {
        private Badge_Repository _repo = new Badge_Repository();

        public void Run()
        {
            _repo.SeedDictionary();
            Menu();
        }

        private void Menu()
        {

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("----Welcome to the Komodo Insurance Securit Admin Interface----");
                Console.WriteLine("What would you like to do?\n" +
                    "1) Create a new badge\n" +
                    "2) Update an existing badge\n" +
                    "3) List all existing badges\n" +
                    "4) Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddNewBadge();
                        break;
                    case "2":
                        UpdateExistingBadge();
                        break;
                    case "3":
                        ReturnExistingBadges();
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
        public void AddNewBadge()
        {
            Console.Clear();
            Console.Write("What is the number on the new badge: ");
            string iDNumberString = Console.ReadLine();
            int id = int.Parse(iDNumberString);
            Console.Write("List a door it needs access to: ");
            string doors = Console.ReadLine();
            List<string> newDoor = new List<string>();
            newDoor.Add(doors);
           
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Write("Any other doors (y/n)? ");
                string input = Console.ReadLine().ToLower();
                
                switch(input)
                {
                    case "y":
                        Console.Write("List a door it needs access to: ");
                        string inputNewDoor = Console.ReadLine();
                        newDoor.Add(inputNewDoor);
                        break;
                    case "n":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please press (y) or (n).");
                        break;
                }
                Console.Clear();
            }
            _repo.AddEntry(id, newDoor);
        }

        private void UpdateExistingBadge()
        {
            List<string> badgeNumbers = _repo.ReturnBadges();
            string combinedBadgeString = string.Join("\n", badgeNumbers);
            Console.Clear();
            Console.WriteLine("Current Badge #'s");
            Console.WriteLine("-----------------");
            Console.WriteLine($"{combinedBadgeString}");
            Console.WriteLine("-----------------\n");
            Console.Write("What is the badge you would like to update? ");
            string iDNumberString = Console.ReadLine();
            int id = int.Parse(iDNumberString);
            List<string> returnDoor = _repo.ReturnDoorSet(id);
            string combinedDoorString = string.Join(",", returnDoor);
            Console.WriteLine($"{iDNumberString} has access to doors {combinedDoorString}\n");

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("What would you like to do?\n" +
                    "1: Remove a door\n" +
                    "2: Add a door\n" +
                    "3: Exit");
           
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Which door would you like to remove? ");
                        string doorInput = Console.ReadLine();
                        _repo.DeleteDoor(id, doorInput);
                        Console.WriteLine("Door Deleted.\n");
                        keepRunning = false;
                        break;
                    case "2":
                        Console.Write("What is the door you would like to add? ");
                        string newDoorInput = Console.ReadLine();
                        _repo.AddDoor(id, newDoorInput);
                        Console.WriteLine("Door Added.\n");
                        keepRunning = false;
                        break;
                    case "3":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please press (1), (2), or (3).");
                        break;
                }
            }
        }

        private void ReturnExistingBadges()
        {
            Console.Clear();
            Console.WriteLine("Badge #       Door Access");
            Console.WriteLine("--------------------------------");
            List<string> badgeNumbers = _repo.ReturnBadges();
            List<string> doorNumbers = _repo.ReturnDoors();
            var fullList = badgeNumbers.Zip(doorNumbers, (b, d) => new { Badge = b, Door = d });
            foreach (var bd in fullList)
            {
                Console.WriteLine(bd.Badge + "          " + bd.Door);
            }
        }
    }
}
