using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Nutrition : BasicHealthPrinciples
    {
        public Nutrition(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about nutrition\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/NutritionPic.jpg";
        }

        public override string SecondaryStory()
        {
            return "\nThe nutrition consicts 60% of our time.\nIt is good practise to drink alcohol at least 2-3 liters a day\n";
        }
    }
}
