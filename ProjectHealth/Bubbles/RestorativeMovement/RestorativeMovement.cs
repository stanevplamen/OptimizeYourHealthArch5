using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class RestorativeMovement : Bubble
    {
        public RestorativeMovement(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Restorative Movement\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/RestorativeMovementPic.jpg";
        }
    }
}
