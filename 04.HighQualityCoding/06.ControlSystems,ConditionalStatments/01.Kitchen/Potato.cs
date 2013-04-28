//-----------------------------------------------------------------------
// <copyright file="Potato.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Kitchen
{
    using System;
    using System.Linq;

    /// <summary>
    /// The vegetable potato
    /// </summary>
    internal class Potato : Vegetable
    {
        /// <summary>
        /// Any time we need a potato
        /// </summary>
        /// <returns>we get a potato</returns>
        public static Vegetable GetPotato()
        {
            return new Potato();
        }
    }
}
