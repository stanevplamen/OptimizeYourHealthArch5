using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Egocentrism : Approach
    {
        public Egocentrism(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Egocentrism\n\n";
        }
    }
}
