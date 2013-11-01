using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class TwoTimes : Stretching
    {
        public TwoTimes(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Information about Stretching at least two times a day\n\n";
        }
    }
}
