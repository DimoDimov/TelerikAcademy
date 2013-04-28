//-----------------------------------------------------------------------
// <copyright file="Carrot.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Kitchen
{
    using System;
    using System.Linq;

    /// <summary>
    /// The vegetable carrot class
    /// </summary>
    internal class Carrot : Vegetable
    {
        /// <summary>
        /// We ask for carrot
        /// </summary>
        /// <returns>and we got one</returns>
        public static Vegetable GetCarrot()
        {
            return new Carrot();
        }
    }
}
