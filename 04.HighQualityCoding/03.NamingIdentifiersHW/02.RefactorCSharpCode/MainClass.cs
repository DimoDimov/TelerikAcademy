//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------

namespace _02.RefactorCSharpCode
{
    using System;

    /// <summary>
    /// The main working class 
    /// </summary>
    internal class MainClass
    {
        /// <summary>
        /// Creates humans with algorithm based on their age
        /// </summary>
        /// <param name="age">Used to calculate if its male or female person</param>
        public void CreateHuman(int age)
        {
            Human newHuman = new Human();
            newHuman.Age = age;

            if (age % 2 == 0)
            {
                newHuman.Name = "Male Person";
                newHuman.Gender = Gender.Male;
            }
            else
            {
                newHuman.Name = "Female Person";
                newHuman.Gender = Gender.Female;
            }
        }

        /// <summary>
        /// Program's entry point
        /// </summary>
        private static void Main()
        {
            // nothing to do
        }
    }
}
