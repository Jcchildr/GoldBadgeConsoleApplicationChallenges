using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._00_Challenge_Repository
{
    public class CompanyOutings
    {
        readonly List<CompanyOutings_Content> _repoCompanyOutings = new List<CompanyOutings_Content>();
       

        public void AddContentToList(CompanyOutings_Content content)
        {
            _repoCompanyOutings.Add(content);
        }

        public List<CompanyOutings_Content> ReturnEvents()
        {
            return _repoCompanyOutings;
        }

        public double ReturnSum()
        {

            List<CompanyOutings_Content> _Contents = _repoCompanyOutings;
            double sumOfOutings = new double();
            foreach (var total in _Contents)
            {
                sumOfOutings += total.CostOfEvent;
            }
            return sumOfOutings;
        }

        public double ReturnGolfItemCost()
        {
            List<CompanyOutings_Content> _Contents = _repoCompanyOutings;
            double sumOfType = new double();
            foreach (var total in _Contents)
            {
                if(total.EventType == "Golf")
                { 
                    sumOfType += total.CostOfEvent;
                }
            }
            return sumOfType;
        }

        public double ReturnBowlingItemCost()
        {
            List<CompanyOutings_Content> _Contents = _repoCompanyOutings;
            double sumOfType = new double();
            foreach (var total in _Contents)
            {
                if (total.EventType == "Bowling")
                {
                    sumOfType += total.CostOfEvent;
                }
            }
            return sumOfType;
        }

        public double ReturnAmusementParkItemCost()
        {
            List<CompanyOutings_Content> _Contents = _repoCompanyOutings;
            double sumOfType = new double();
            foreach (var total in _Contents)
            {
                if (total.EventType == "Amusement Park")
                {
                    sumOfType += total.CostOfEvent;
                }
            }
            return sumOfType;
        }

        public double ReturnConcertItemCost()
        {
            List<CompanyOutings_Content> _Contents = _repoCompanyOutings;
            double sumOfType = new double();
            foreach (var total in _Contents)
            {
                if (total.EventType == "Concert")
                {
                    sumOfType += total.CostOfEvent;
                }
            }
            return sumOfType;
        }


        public void SeedMenu()
        {
            CompanyOutings_Content eventOne = new CompanyOutings_Content("Golf", 20, "03/23/2020", 72.84d, 1456.80d );
            CompanyOutings_Content eventTwo = new CompanyOutings_Content("Bowling", 34, "04/13/2020", 10.15d, 345.10d);
            CompanyOutings_Content evenThree = new CompanyOutings_Content("Amusement Park", 36, "04/27/2020", 99.11d, 3567.99d);
            CompanyOutings_Content eventFour = new CompanyOutings_Content("Golf", 15, "04 /30/2020", 66.92d, 1003.80d);
            CompanyOutings_Content eventFive = new CompanyOutings_Content("Bowling", 41, "05/05/2020", 11.15d, 457.15d);
            CompanyOutings_Content eventSix = new CompanyOutings_Content("Concert", 26, "05/29/2020", 55.00d, 1430.00d);
            CompanyOutings_Content eventSeven = new CompanyOutings_Content("Concert", 45, "06/15/2020", 45.00d, 2025.00d);

            AddContentToList(eventOne);
            AddContentToList(eventTwo);
            AddContentToList(evenThree);
            AddContentToList(eventFour);
            AddContentToList(eventFive);
            AddContentToList(eventSix);
            AddContentToList(eventSeven);
        }

        /*public string EventNameTest() 
        {
           string correctEventName = new string;
           foreach (var value in _eventsDictionary.Keys)
               if (value == "Golf" || value == "Bowling" || value == "Amusement Park" || value == "Concert")
               {
                   correctEventName = value;
               }
               else
               {
                   EventType = "NA";
               }
           return correctEventName;
        }

         Dictionary<string, List<double>> _eventsDictionary = new Dictionary<string, List<double>>();
        public void AddContentToDictionary()

        public void SeedDictionary()
        {
            List<double> golfCost = new List<double> { 1456.80d, 1003.80d };

            List<double> bowlingCost = new List<double> { 457.15d, 345.10d };

            List<double> parkCost = new List<double> { 3567.99d };

            List<double> concertCost = new List<double> { 1430.00d, 2025.00d };

            _eventsDictionary.Add("Golf", golfCost);
            _eventsDictionary.Add("Bowling", bowlingCost);
            _eventsDictionary.Add("Amusement Park", parkCost);
            _eventsDictionary.Add("Concert", concertCost);
        }*/

    }
}
