//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _02.RefactorTheCode
{
    using System;
    using System.Linq;

    /// <summary>
    /// Main class of the program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// To cook something we must first prepare vegetable
        /// </summary>
        /// <param name="potato">preparing vegetable</param>
        internal static void Cook(Vegetable potato)
        {
            bool isPeeled = potato.IsPeeled;
            bool isRotten = potato.IsRotten;
            if (potato != null)
            {
                if (isPeeled && !isRotten)
                {
                    Console.WriteLine("Potato has been cooked");
                }
            }
        }

        /// <summary>
        /// The Cell Visit method
        /// </summary>
        internal static void VisitCell()
        {
            Console.WriteLine("Cell has been visited");
        }

        /// <summary>
        /// The main entry point of the project
        /// </summary>
        internal static void Main()
        {
            Potato potato = new Potato();
            potato.Peel();
            potato.Cut();
            Cook(potato);
            
            int x = 3;
            int y = 3;
            int minX = 1;
            int maxX = 5;   
            int minY = 1;
            int maxY = 5;
            bool isYBetweenMinMax = minY <= y && y <= maxY;
            bool isXBetweenMinMax = minX <= x && x <= maxX;
            bool shoudVisitCell = true;
            if (isXBetweenMinMax && (isYBetweenMinMax && shoudVisitCell))
            {
                VisitCell();
            }
        }        
    }
}
