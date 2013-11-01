using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Rules : BasicHealthPrinciples
    {
        public Rules(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about basic rules\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/RulesPic.jpg";
        }

        public override string SecondaryStory()
        {
            return "\nSome more information\n";
        }
    }
}
