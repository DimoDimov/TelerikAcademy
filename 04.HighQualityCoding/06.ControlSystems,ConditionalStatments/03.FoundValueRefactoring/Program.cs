//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _03.FoundValueRefactoring
{
    using System;
    using System.Linq;

    /// <summary>
    /// The main class of the program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// the main entry point of the program
        /// </summary>
        internal static void Main()
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Console.WriteLine("please input integer that should be found. It must be between 10 and 100 and to be divisible by 10");
            int expectedValue = int.Parse(Console.ReadLine());

            bool isValueFound = false;

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isValueFound = true;
                        break;
                    }
                }
            }

            ////More code here

            if (isValueFound)
            {
                Console.WriteLine("Value found");
            }
            else
            {
                Console.WriteLine("Value was not found");
            }
        }
    }
}
