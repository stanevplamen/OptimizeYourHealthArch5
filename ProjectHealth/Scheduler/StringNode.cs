using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth
{
    public class StringNode
    {
        public StringNode()
        {
            // default constructor
        }

        public StringNode(string col1, string col2, string col3)
        {
            Date = col1;
            Title = col2;
            Description = col3;
        }

        public string Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
