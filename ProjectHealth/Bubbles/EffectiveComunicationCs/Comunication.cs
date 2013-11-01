using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Comunication : Bubble
    {
        public Comunication(int id, string name)
            : base(id, name)
        {
        }

        public override string Story()
        {
            return "Comunication, Interaction\n\n";
        }

        public override string Image()
        {
            return @"pack://application:,,,/Images/ComunicationPic.jpg";
        }
    }
}
