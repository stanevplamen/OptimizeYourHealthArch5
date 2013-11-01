using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class SameDays : BasicHealthPrinciples
    {
        public SameDays(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about same days\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/SameDaysPic.jpg";
        }

        public override string SecondaryStory()
        {
            return "\nSome days information\n";
        }
    }
}
