using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Fats : FoodInfluence
    {
        public Fats(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Fats\n\n";
        }
    }
}
