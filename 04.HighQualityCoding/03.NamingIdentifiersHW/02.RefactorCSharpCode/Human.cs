//-----------------------------------------------------------------------
// <copyright file="Human.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------

namespace _02.RefactorCSharpCode
{
    using System;
    using System.Linq;
    
    /// <summary>
    /// The typical Human class used for method CreateHuman
    /// </summary>
    internal class Human
    {
        /// <summary>
        /// Gets or sets Human's gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets Human's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Human's age
        /// </summary>
        public int Age { get; set; }
    }
}
