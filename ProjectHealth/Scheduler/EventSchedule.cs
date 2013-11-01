using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace ProjectHealth.Scheduler
{
    public class EventSchedule
    {
        public OrderedBag<EventNode> scheduleStructure { get; set; }

        public EventSchedule()
        {
            this.scheduleStructure = new OrderedBag<EventNode>();
        }
        public void Add(EventNode newEvent)
        {
            this.scheduleStructure.Add(newEvent);
        }

        public void Remove(ref EventNode oldEvent) 
        {
            if (scheduleStructure.Contains(oldEvent))
            {
                scheduleStructure.Remove(oldEvent);
            }
        }
    }
}
