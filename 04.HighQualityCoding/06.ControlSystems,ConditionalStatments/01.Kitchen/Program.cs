//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Kitchen
{
    using System;
    using System.Linq;

    /// <summary>
    /// Main work class of the program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// the main entry point of the program
        /// </summary>
        internal static void Main()
        {
            Chef pesho = new Chef();
            pesho.Cook();
        }
    }
}
