using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Bubbles
{
    public class Bubble : IComparable<Bubble>
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public string Supplement { get; private set; }

        public string StoryName2 { get; private set; }

        public string StoryName3 { get; private set; }

        protected Bubble(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            this.Supplement = Story().Trim();
            this.StoryName2 = SecondaryStory().Trim();
            this.StoryName3 = ThirdlyStory().Trim();
        }

        public virtual string Story()
        {
            return "Main Page\n";
        }

        public virtual string Image()
        {
            return @"pack://application:,,,/Images/HealthPic.jpg"; // @"pack://application:,,,/images/Globe.png"
        }

        public virtual string SecondaryStory()
        {
            return "\n";
        }

        public virtual string SecondaryImage()
        {
            return @"pack://application:,,,/Images/empty.png";
        }

        public virtual string ThirdlyStory()
        {
            return "\n";
        }

        public int CompareTo(Bubble other)
        {
            int result = this.ID.CompareTo(other.ID);
            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);
            }
            return result;
        }
    }
}
