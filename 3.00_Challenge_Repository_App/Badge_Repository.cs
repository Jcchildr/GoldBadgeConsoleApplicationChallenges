using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Repository_App
{
    public class Badge_Repository
    {
        Dictionary<int, List<string>> _badgeDictionary = new Dictionary<int, List<string>>();

        //Add a badge and doors it needs acess to

        //update exisiting badge: take badge # and give doors
        //While loop for options Remove door or Add door

        //List all badges


        public List<string> ReturnDoors()
        {
            List<string> allDoors = new List<string>();
            foreach (var value in _badgeDictionary.Values)
            {
                string toString = string.Join(",", value);
                allDoors.Add(toString);
            }
            return allDoors;
        }

        public List<string> ReturnBadges()
        {
            List<string> allBadges = new List<string>();
            foreach (var key in _badgeDictionary.Keys)
            {
                string stringKey = key.ToString();
                allBadges.Add(stringKey);
            }
            return allBadges;
        }

        public void DeleteDoor(int id, string doorInput)
        {
            if (_badgeDictionary.ContainsKey(id))
            {
                foreach(var door in _badgeDictionary[id].ToList())
                {
                    if (door == doorInput)
                    {
                        _badgeDictionary[id].Remove(door);
                    }
                }
            }
        }

        public List<string> ReturnDoorSet(int id)
        {
            if (_badgeDictionary.ContainsKey(id))
            {
                return _badgeDictionary[id]; 
            }
            return null;
        }

        public void AddEntry(int id, List<string> doors)
        {
            if (!_badgeDictionary.ContainsKey(id))
            {
                _badgeDictionary.Add(id, doors);
            }
        }

        public void AddDoor(int id, string newDoorInput)
        {
            if (_badgeDictionary.ContainsKey(id))
            {
                _badgeDictionary[id].Add(newDoorInput);
            }
        }

        public void SeedDictionary()
        {
            List<string> iDOne = new List<string> {"A22", "A23", "A42"};

            List<string> iDTwo = new List<string> {"C34", "C14" };

            List<string> iDThree = new List<string>{ "B33", "B5" , "B8" , "B2"};

            List<string> iDFour = new List<string> {"237", "101"};

            _badgeDictionary.Add(34234, iDOne);
            _badgeDictionary.Add(11255, iDTwo);
            _badgeDictionary.Add(54443, iDThree);
            _badgeDictionary.Add(10101, iDFour);
        }
    }
}
