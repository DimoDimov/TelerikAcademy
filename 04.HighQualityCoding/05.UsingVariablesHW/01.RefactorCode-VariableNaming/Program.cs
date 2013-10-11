//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.RefactorCode_VariableNaming
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
        public static void Main()
        {
            Size figure = new Size(10, 15);
            Size rotatedFigure = Size.GetRotatedSize(figure, 35);

            Console.WriteLine("The figure's width = {0}; height = {1}", figure.Width, figure.Height);

            Console.WriteLine("The rotated figure's width = {0}; height = {1}", rotatedFigure.Width, rotatedFigure.Height);
        }
    }
}
