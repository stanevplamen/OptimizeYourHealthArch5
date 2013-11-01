using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHealth.Scheduler
{
    public class EventNode : IComparable<EventNode>
    {
        #region Fields

        private DateTime datetimeEvent;
        private string title;
        private string description;

        #endregion Fields

        #region Properties

        public DateTime DatetimeEvent
        {
            get
            {
                return this.datetimeEvent;
            }
            set
            {
                this.datetimeEvent = value;
            }
        }

        public string Title
	    {
		    get 
		    {
			    return this.title;
		    }
		    set
		    {
			    if (value == null)
			    {
                    this.title = "Not set";
			    }
                else
                {
                    this.title = value;
                }
		    }
	    }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (value == null)
                {
                    this.description = "Not specified";
                }
                else
                {
                    this.description = value;
                }
            }
        }

        #endregion Properties

        #region Constructor

        public EventNode(DateTime datetimeEvent, string title, string description)
	    {
            this.DatetimeEvent = datetimeEvent;
            this.Title = title;
            this.Description = description;
	    }

        public EventNode()
        {
            // default constructor
        }

        #endregion 

        #region Methods

        public int CompareTo(EventNode other)
        {
            int result = this.DatetimeEvent.CompareTo(other.DatetimeEvent);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;
        }

        #endregion Methods
    }
}
