using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._00_Challenge_Repository
{
    public class CompanyOutings_Content
    {
        
        public string EventType { get; set;}
        public int NumberInAttendance { get; set; }
        public string DateOfEvent { get; set; }
        public double CostPerPerson { get; set; }
        public double CostOfEvent { get; set; }
        

        public CompanyOutings_Content() { }

        public CompanyOutings_Content(string eventType, int numberInAttendance, string dateOfEvent, double costPerPerson, double costOfEvent)
        {
            EventType = eventType;
            NumberInAttendance = numberInAttendance;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            CostOfEvent = costOfEvent;
        }
       /* public DateTime DateTimeOfEvent;
        public string DateOFEvent
        {
            get { return DateTimeOfEvent.ToString(); }
            set { DateTime.Parse(DateOFEvent); }
        }*/
    }
}
