//-----------------------------------------------------------------------
// <copyright file="Event.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Events
{
    using System;
    using System.Text;

    /// <summary>
    /// Event with three parameters
    /// </summary>
    internal class Event : IComparable
    {
        /// <summary>
        /// holds the event's date
        /// </summary>
        private DateTime date;

        /// <summary>
        /// holds the event's title
        /// </summary>
        private string title;

        /// <summary>
        /// holds the event's location
        /// </summary>
        private string location;

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class
        /// </summary>
        /// <param name="date">Inputs date</param>
        /// <param name="title">Inputs title</param>
        /// <param name="location">Inputs location</param>
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        /// <summary>
        /// Gets Date
        /// </summary>
        public DateTime Date
        {
            get
            {
                return this.date;
            }

            private set
            {
                this.date = value;
            }
        }

        /// <summary>
        /// Gets Title
        /// </summary>
        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                this.title = value;
            }
        }

        /// <summary>
        /// Gets Location
        /// </summary>
        public string Location
        {
            get
            {
                return this.location;
            }

            private set
            {
                this.location = value;
            }
        }

        /// <summary>
        /// Implements IComparable
        /// </summary>
        /// <param name="otherObj">inputs object for checking</param>
        /// <returns>comparing result: 1, 0 or -1</returns>
        public int CompareTo(object otherObj)
        {
            Event otherEvent = otherObj as Event;

            if (this == null)
            {
                if (otherEvent == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else if (otherEvent == null)
            {
                return 1;
            }
            else
            {
                int byDate = this.Date.CompareTo(otherEvent.Date);
                int byTitle = this.Title.CompareTo(otherEvent.Title);
                int byLocation = this.Location.CompareTo(otherEvent.Location);

                if (byDate == 0)
                {
                    if (byTitle == 0)
                    {
                        return byLocation;
                    }
                    else
                    {
                        return byTitle;
                    }
                }
                else
                {
                    return byDate;
                }
            }
        }

        /// <summary>
        /// overrides ToString() method
        /// </summary>
        /// <returns>Event's implementation ToString()</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            stringBuilder.Append(
                this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            stringBuilder.Append(" | " + this.Title);
            
            if (this.Location != null && 
                this.Location != string.Empty)
            {
                stringBuilder.Append(" | " + this.Location);
            }
                
            return stringBuilder.ToString();
        }
    }
}
