using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Humility : Models
    {
        public Humility(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Humility \n\n";
        }
    }
}
