using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Walking : NaturalMovement
    {
        public Walking(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Walking \n\n";
        }
    }
}
