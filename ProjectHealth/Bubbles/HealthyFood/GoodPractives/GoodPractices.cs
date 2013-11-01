using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class GoodPractices : HealthyFoodInfo
    {
        public GoodPractices(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Good Practices\n\n";
        }
    }
}
