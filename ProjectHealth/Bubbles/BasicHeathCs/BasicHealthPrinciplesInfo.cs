using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class BasicHealthPrinciplesInfo : BasicHealthPrinciples
    {
        public BasicHealthPrinciplesInfo(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "More info about Health Principles\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/HealthPrinciplesPic.jpg";
        }
    }
}
