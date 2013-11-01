using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Sport : BasicHealthPrinciples
    {
        public Sport(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about sport\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/SportPic.jpg";
        }

        public override string SecondaryStory()
        {
            return "\nSome sport information\n";
        }
    }
}
