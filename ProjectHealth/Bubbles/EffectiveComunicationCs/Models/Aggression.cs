using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Aggression : Models
    {
        public Aggression(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Aggression \n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/AggresionPic.jpg";
        }
    }
}
