using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._00_Challange_Repository
{
    public class Claims_Repository
    {
        readonly List<ClaimsContent> _repoClaims = new List<ClaimsContent>();
        readonly Queue<ClaimsContent> queue = new Queue<ClaimsContent>();

        public List<ClaimsContent> ReturnClaims()
        {
            return _repoClaims;
        }

        public Queue<ClaimsContent> ReturnQueue()
        {
            return queue;
        }

        public void AddContentToList(ClaimsContent content)
        {
            _repoClaims.Add(content);
        }

        public void AddContentToQueue(ClaimsContent content)
        {
            queue.Enqueue(content);
        }


        public void SeedClaimsList()
        {
            var dateOfIncidentOne = new DateTime(2021, 03, 24);
            var dateOfClaimOne = new DateTime(2021, 03, 27);
            ClaimsContent claimNumberOne = new ClaimsContent(1, "Car", "Accident involving Chickens on SR 38.", 599.00d, dateOfIncidentOne, dateOfClaimOne, true);
            var dateOfIncidentTwo = new DateTime(2021, 03, 03);
            var dateOfClaimTwo = new DateTime(2021, 03, 17);
            ClaimsContent claimNumberTwo = new ClaimsContent(2, "Home", "Boardgame causes house to turn into a jungle.", 250000.00d, dateOfIncidentTwo, dateOfClaimTwo, true);
            var dateOfIncidentThree = new DateTime(2021, 3, 21);
            var dateOfClaimThree = new DateTime(2021, 3, 23);
            ClaimsContent claimNumberThree = new ClaimsContent(3, "Theft", "Stolen Monet painting.", 3000000.00d, dateOfIncidentThree, dateOfClaimThree, true);

            AddContentToList(claimNumberOne);
            AddContentToList(claimNumberTwo);
            AddContentToList(claimNumberThree);

            AddContentToQueue(claimNumberOne);
            AddContentToQueue(claimNumberTwo);
            AddContentToQueue(claimNumberThree);
        }
    }
}
