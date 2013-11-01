using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Carbohydrates : Nutrition
    {
        public Carbohydrates(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Carbohydrates can give you soothe and comfort.\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/CarbohydratesPic.jpg";
        }

        public override string SecondaryStory()
        {
            return "\n\nSome of the foods highest in Carbohydrates are Sugar and sugar products: cakes, candies, rich sugar drinks, jams, potatoes, pizzas, bakeries, etc. Good carb foods are most of the plant foods: grains, beans, vegetables, and fruits, etc.. Carbohydrates could be successfully used in different kinds of diets like weigth losing or sport practicing.\nThe excessive use of sugar and pasta products should be aboided.\n";
        }
    }
}
