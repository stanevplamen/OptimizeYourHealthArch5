using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Water : Nutrition
    {
        public Water(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Water\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/WaterPic.jpg";
        }

        public override string SecondaryStory()
        {
            return "\nThe water consicts 90% of our planet.\nIt is good practise to drink at least 2-3 liters a day\n";
        }
    }
}
