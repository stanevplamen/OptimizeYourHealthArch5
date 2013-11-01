using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class CaloricIntake : HealthyFoodInfo
    {
        public CaloricIntake(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Caloric Intake\n\n";
        }
    }
}
