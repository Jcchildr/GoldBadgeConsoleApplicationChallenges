using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_App
{
    public class CafeMenuContent
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string BriefDescription { get; set; }
        public string ListOfIngredients { get; set; }
        public double Price { get; set; }
       
        public CafeMenuContent() { }

        public CafeMenuContent (int mealNumber, string mealName, string briefDescription, string listOfIngredients, double price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
                BriefDescription = briefDescription;
                ListOfIngredients = listOfIngredients;
                Price = price;
        }
    }
}
