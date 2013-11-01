using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Desire : Bubble
    {
        public Desire(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Desire occurence\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/DesirePic.jpg";
        }
    }
}
