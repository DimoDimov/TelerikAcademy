//-----------------------------------------------------------------------
// <copyright file="CSHarpCleanCode.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.CSharpCleanCode
{
    using System;

    /// <summary>
    /// Just cleaning code
    /// </summary>
    internal class CSHarpCleanCode
    {
        /// <summary>
        /// Represents how our cleaned code works
        /// </summary>
        public static void Main()
        {
            CSHarpCleanCode.NestedCLass instance =
                new CSHarpCleanCode.NestedCLass();

            instance.PrintValueToString(true);
        }

        /// <summary>
        /// Typical nested class
        /// </summary>
        private class NestedCLass
        {
            /// <summary>
            /// Prints the input boolean value to the console
            /// </summary>
            /// <param name="value">inputted value</param>
            public void PrintValueToString(bool value)
            {
                string variableAsString = value.ToString();
                Console.WriteLine(variableAsString);
            }
        }
    }
}
