using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Techniques : Comunication
    {
        public Techniques(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Techniques\n\n";
        }
    }
}
