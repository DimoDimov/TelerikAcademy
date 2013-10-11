//-----------------------------------------------------------------------
// <copyright file="Size.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _01.RefactorCode_VariableNaming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Size declares size of a figure by height and width
    /// </summary>
    internal class Size
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class
        /// </summary>
        /// <param name="width">holds the width</param>
        /// <param name="height">holds the height</param>
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        #endregion

        #region properties

        /// <summary>
        /// Gets object's width
        /// </summary>
        public double Width { get; private set; }

        /// <summary>
        /// Gets object's height
        /// </summary>
        public double Height { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the rotated size of a figure
        /// </summary>
        /// <param name="size">inputted size to be rotated</param>
        /// <param name="angleOfRotation">inputted angle of rotation</param>
        /// <returns>the calculated newSize of the rotated object</returns>
        public static Size GetRotatedSize(Size size, double angleOfRotation)
        {
            double newWidth = (Math.Abs(Math.Cos(angleOfRotation)) * size.Width) +
            (Math.Abs(Math.Sin(angleOfRotation)) * size.Height);

            double newHeight = (Math.Abs(Math.Sin(angleOfRotation)) * size.Width) +
            (Math.Abs(Math.Cos(angleOfRotation)) * size.Height);

            Size rotatedSize = new Size(newWidth, newHeight);
            
            return rotatedSize;
        }

        #endregion
    }
}
