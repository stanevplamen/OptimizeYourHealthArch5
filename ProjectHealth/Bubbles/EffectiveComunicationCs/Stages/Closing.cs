using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Closing : Stages
    {
        public Closing(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about  Closing \n\n";
        }
    }
}
