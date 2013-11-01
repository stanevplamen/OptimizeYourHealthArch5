using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class RestTime : BasicHealthPrinciples
    {
        public RestTime(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about rest\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/RestPic.jpg";
        }

        public override string SecondaryStory()
        {
            return "\nSome rest information\n";
        }
    }
}
