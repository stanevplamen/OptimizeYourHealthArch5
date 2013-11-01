using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class SuperFoods : HealthyFoodInfo
    {
        public SuperFoods(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Stress Super Foods\n\n";
        }
    }
}
