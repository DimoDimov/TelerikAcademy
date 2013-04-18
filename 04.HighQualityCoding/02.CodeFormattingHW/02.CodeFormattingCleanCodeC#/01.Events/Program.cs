//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Events
{
    using System;

    /// <summary>
    /// Main working class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Instance of the EventHolder class.So Just Code Suggests name Output to start
        /// with small letter, as StyleCop says to start with bigger letter.
        /// Its Readonly and I will use the big first letter such as for Constants.
        /// </summary>
        private static readonly EventHolder EventHolder = new EventHolder();

        /// <summary>
        /// Main entry point of the program
        /// </summary>
        internal static void Main()
        {
            while (ExecuteNextCommand()) 
            { 
            }

            Console.WriteLine(Messages.OutputString);
        }

        /// <summary>
        /// Executes next command
        /// </summary>
        /// <returns>True if program is being executed</returns>
        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command[0] == 'A') 
            { 
                AddEvent(command); 
                return true; 
            }

            if (command[0] == 'D') 
            { 
                DeleteEvents(command); 
                return true; 
            }

            if (command[0] == 'L') 
            { 
                ListEvents(command); 
                return true; 
            }

            if (command[0] == 'E') 
            { 
                return false; 
            }

            return false;
        }

        /// <summary>
        /// Lists the Events
        /// </summary>
        /// <param name="command">inputs command</param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);
            EventHolder.ListEvents(date, count);
        }

        /// <summary>
        /// Deletes Events
        /// </summary>
        /// <param name="command">inputs command</param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            EventHolder.DeleteEvents(title);
        }

        /// <summary>
        /// Adds Event
        /// </summary>
        /// <param name="command">inputs command</param>
        private static void AddEvent(string command)
        {
            DateTime date; 
            string title; 
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);

            EventHolder.AddEvent(date, title, location);
        }

        /// <summary>
        /// Gets Parameters
        /// </summary>
        /// <param name="commandForExecution">What command to execute</param>
        /// <param name="commandType">Type of command</param>
        /// <param name="dateAndTime">Date and time</param>
        /// <param name="eventTitle">Title of the event</param>
        /// <param name="eventLocation">Event's location</param>
        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle =
                    commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(
                    firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        /// <summary>
        /// Gets the date
        /// </summary>
        /// <param name="command">command name</param>
        /// <param name="commandType">command type</param>
        /// <returns>parsed date</returns>
        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }
    }
}