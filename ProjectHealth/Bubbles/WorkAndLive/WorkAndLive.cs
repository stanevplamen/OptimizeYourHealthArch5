using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class WorkAndLive : Bubble
    {
        public WorkAndLive(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Work And Live Balance\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/WorkAndLivePic.jpg";
        }
    }
}
