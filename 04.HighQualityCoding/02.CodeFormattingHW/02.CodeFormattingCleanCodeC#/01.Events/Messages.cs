//-----------------------------------------------------------------------
// <copyright file="Messages.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Events
{
    using System;
    using System.Text;

    /// <summary>
    /// Messages - Adds, Stores, Deletes and Prints Events
    /// </summary>
    internal static class Messages
    {
        /// <summary>
        /// Output storage. So Just Code Suggests name Output to start
        /// with small letter, as StyleCop says to start with bigger letter.
        /// Its Readonly and I will use the big first letter such as for Constants.
        /// </summary>
        private static readonly StringBuilder Output = new StringBuilder();

        /// <summary>
        /// Gets output
        /// </summary>
        public static string OutputString
        {
            get
            {
                return Output.ToString();
            }
        }

        /// <summary>
        /// Event Adder
        /// </summary>
        public static void EventAdded()
        { 
            Output.Append("Event added" + Environment.NewLine); 
        }

        /// <summary>
        /// Deletes Events
        /// </summary>
        /// <param name="amount">amount of events to be deleted</param>
        public static void EventDeleted(int amount)
        {
            if (amount == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted{1}", amount, Environment.NewLine);
            }
        }

        /// <summary>
        /// Prints if no events were found
        /// </summary>
        public static void NoEventsFound() 
        { 
            Output.Append("No events found" + Environment.NewLine); 
        }

        /// <summary>
        /// Prints the Event
        /// </summary>
        /// <param name="eventToPrint">Event to print</param>
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + Environment.NewLine);
            }
        }
    }
}
