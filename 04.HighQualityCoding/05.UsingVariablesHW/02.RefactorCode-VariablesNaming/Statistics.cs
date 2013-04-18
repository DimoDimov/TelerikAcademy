//-----------------------------------------------------------------------
// <copyright file="Statistics.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace _02.RefactorCode_VariablesNaming
{
    using System;
    using System.Linq;

    /// <summary>
    /// Works with inputting an array of doubles.
    /// Used to create an instance and to print the maximal number,
    /// the minimal number and the average value of the array.
    /// </summary>
    internal class Statistics
    {
        #region Fields
        
        /// <summary>
        /// The readonly array prepared for storing the inputted array.
        /// It hold its own copy of the original inputted array.
        /// </summary>
        private readonly double[] numbersArr;

        #endregion

        #region Constructors

        /// <summary> 
        /// Initializes a new instance of the<see cref="Statistics"/> class
        /// </summary>
        /// <param name="numbersArr">Inputted array of numbers whose 
        /// statistics we will print</param>
        public Statistics(double[] numbersArr)
        {
            this.numbersArr = numbersArr.Clone() as double[];
        }

        #endregion

        #region Method

        /// <summary>
        /// Prints the average value of the inputted array
        /// </summary>
        public void PrintAverageValue()
        {
            double sumOfAll = 0;

            for (int i = 0; i < this.numbersArr.Length; i++)
            {
                sumOfAll += this.numbersArr[i];
            }

            double average = sumOfAll / this.numbersArr.Length;

            Console.WriteLine("The average value for all numbers is: {0}", average);
        }

        /// <summary>
        /// Prints the minimal number from the inputted array
        /// </summary>
        public void PrintMinNum()
        {
            double minNumber = double.MaxValue;

            for (int i = 0; i < this.numbersArr.Length; i++)
            {
                if (minNumber > this.numbersArr[i])
                {
                    minNumber = this.numbersArr[i];
                }
            }

            Console.WriteLine("The minimal number is: {0}", minNumber);
        }

        /// <summary>
        /// Prints the maximal number from the inputted array
        /// </summary>
        public void PrintMaxNum()
        {
            double maxNumber = double.MinValue;

            for (int i = 0; i < this.numbersArr.Length; i++)
            {
                if (this.numbersArr[i] > maxNumber)
                {
                    maxNumber = this.numbersArr[i];
                }
            }

            Console.WriteLine("The maximal number is: {0}", maxNumber);
        }

        #endregion
    }
}
