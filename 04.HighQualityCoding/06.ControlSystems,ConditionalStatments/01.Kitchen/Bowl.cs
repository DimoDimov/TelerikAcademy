//-----------------------------------------------------------------------
// <copyright file="Bowl.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Kitchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Bowl is utensil used from Chef to cook his soup.
    /// Chef must prepare vegetables for soup. Vegetables must be 
    /// </summary>
    internal class Bowl
    {
        /// <summary>
        /// here we list all the vegetables that are being used for our soup
        /// </summary>
        internal readonly List<Vegetable> ListOfVegetables = new List<Vegetable>();

        /// <summary>
        /// Here we can take a bowl for starting the cooking
        /// </summary>
        /// <returns>a bowl for cooking</returns>
        public static Bowl GetBowl()
        {
            return new Bowl();
        }

        /// <summary>
        /// We add to the bowl only vegetables
        /// that are already been peeled and cut.
        /// </summary>
        /// <param name="vegetable">the vegetable we want to add to our soup</param>
        public void Add(Vegetable vegetable)
        {
            if (vegetable.IsPeeled)
            {
                if (vegetable.IsCut)
                {
                    this.ListOfVegetables.Add(vegetable);
                    Console.WriteLine("{0} is been Cutted and Peeled and added to bowl", vegetable);
                }
                else
                {
                    Console.WriteLine("{0} is not Cutted. Please cut down the vegetable first!", vegetable);
                }
            }
            else
            {
                Console.WriteLine("{0} is not Peeled. Please peel the vegetable first!", vegetable);
            }
        }
    }
}
