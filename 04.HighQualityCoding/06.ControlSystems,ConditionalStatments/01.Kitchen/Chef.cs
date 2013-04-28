//-----------------------------------------------------------------------
// <copyright file="Chef.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Kitchen
{
    using System;
    using System.Linq;

    /// <summary>
    /// the Chef prepares all necessary to turn the vegetables into 
    /// a delicious soup.
    /// </summary>
    internal class Chef
    {
        /// <summary>
        /// The Chef's main ability to turn vegetables into a soup.
        /// </summary>
        internal void Cook()
        {
            Bowl bowl = Bowl.GetBowl();

            Vegetable potato = Potato.GetPotato();
            
            potato.Cut();
            potato.Peel();
            bowl.Add(potato);

            Vegetable carrot = Carrot.GetCarrot();
            carrot.Peel();
            carrot.Cut();
            bowl.Add(carrot);

            if (bowl.ListOfVegetables != null && bowl.ListOfVegetables.Count > 0)
            {
                Console.WriteLine("Your soup is ready sir");
            }
        }
    }
}
