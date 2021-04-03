using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_App
{
    public class CafeMenuContent_Repository
    {
        List<CafeMenuContent> _repoCafeContent = new List<CafeMenuContent>();

        //CRUD for Application

        public void AddContentToList(CafeMenuContent content)
        {
            _repoCafeContent.Add(content);
        }

        public CafeMenuContent ReturnMealNames(string mealName)
        {
            foreach (CafeMenuContent content in _repoCafeContent)
            {
                if (content.MealName.ToLower() == mealName.ToLower())
                {
                    return content;
                }
               
            }
            return null;
        }

        public bool RemoveMenuItem(string mealName)
        {
            CafeMenuContent content = ReturnMealNames(mealName);

            if (content == null)
            {
                return false;
            }

            int intialCount = _repoCafeContent.Count;
            _repoCafeContent.Remove(content);

            if (intialCount > _repoCafeContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CafeMenuContent> ReturnMenu()
        {
            return _repoCafeContent;
        }

        public void SeedMenuList()
        {
            CafeMenuContent morningGlory = new CafeMenuContent(1, "The Morning Glory", "A breakfest burger to start your day off right.", "Bacon, egg, hash brown, lettuce, tomato, red onion, tomato relish & tarragon mayonnaise.", 10.95);
            CafeMenuContent eggsBenedict = new CafeMenuContent(2, "Eggs Benedict", "A traditional English eggs bene.", "Option of salmon, bacon or mushrooms on our house - made potato rosti topped with sauteed spinach and our house - made hollandaise.", 16.55);
            CafeMenuContent duckCurry = new CafeMenuContent(3, "Duck Curry", "The famous homemade curry with select chilies, spices and seasonings.", "Crispy confit duck, seasonal vegetables, on a bed of coconut rice.", 14.39);

            AddContentToList(morningGlory);
            AddContentToList(eggsBenedict);
            AddContentToList(duckCurry);
        }
    }
}
