//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _02.RefactorCode_VariablesNaming
{
    using System;
    using System.Linq;

    /// <summary>
    /// The main class of the program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main program entry point
        /// </summary>
        internal static void Main()
        {
            double[] numbersArr = new double[] { 10, 12, 14, 22, 34 };
            Statistics numbersArrStatistics = new Statistics(numbersArr);
            numbersArrStatistics.PrintMaxNum();
            numbersArrStatistics.PrintMinNum();
            numbersArrStatistics.PrintAverageValue();
        }
    }
}
