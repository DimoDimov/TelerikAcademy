//-----------------------------------------------------------------------
// <copyright file="EventHolder.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Events
{
    using System;
    using Wintellect.PowerCollections;

    /// <summary>
    /// Holding Events
    /// </summary>
    internal class EventHolder
    {
        /// <summary>
        /// MultiDictionary stores events by title
        /// </summary>
        private readonly MultiDictionary<string, Event> byTitle = 
            new MultiDictionary<string, Event>(true);

        /// <summary>
        /// ordered bag stores events by date
        /// </summary>
        private readonly OrderedBag<Event> byDate = 
            new OrderedBag<Event>();

        /// <summary>
        /// Adds event to Messages
        /// </summary>
        /// <param name="date">inputs date</param>
        /// <param name="title">inputs title</param>
        /// <param name="location">inputs location</param>
        public void AddEvent(
            DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.byTitle.Add(title.ToLower(), newEvent);
            this.byDate.Add(newEvent); 
            Messages.EventAdded();
        }

        /// <summary>
        /// Deletes Event with concrete Title
        /// </summary>
        /// <param name="titleToDelete">Title to be deleted</param>
        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;
            foreach (var eventToRemove in this.byTitle[title])
            {
                removed++;
                this.byDate.Remove(eventToRemove);
            }
            
            this.byTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        /// <summary>
        /// Lists all the events held
        /// </summary>
        /// <param name="date">inputs date</param>
        /// <param name="count">inputs how many methods to be shown</param>
        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow =
                this.byDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int shown = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (shown == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                shown++;
            }

            if (shown == 0)
            {
                Messages.NoEventsFound();
            }
        }
    } 
}
