using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class FiveTimes : Nutrition
    {
        public FiveTimes(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about 5 times a day feeding\n\n";
        }
    }
}
