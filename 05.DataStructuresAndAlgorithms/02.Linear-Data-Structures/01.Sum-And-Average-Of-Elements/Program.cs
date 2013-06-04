namespace _01.Sum_And_Average_Of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
     * Write a program that reads from the console a sequence of 
     * positive integer numbers. The sequence ends when empty 
     * line is entered. Calculate and print the sum and average 
     * of the elements of the sequence. Keep the sequence in List<int>.
     */

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberContainer = new List<int>();

            Console.WriteLine("Please enter the numbers: ");

            while(true)
            {
                string readLine = Console.ReadLine();

                if (readLine == string.Empty)
                {
                    break;
                }

                int parsedNum = 0;

                bool isParsed = int.TryParse(readLine, out parsedNum);

                if (isParsed)
                {
                    if (parsedNum >= 0)
                    {
                        numberContainer.Add(parsedNum);
                    }
                }
            }

            int sequenceSum = numberContainer.Sum();
            double average = numberContainer.Average();

            Console.WriteLine("The sum = {0}", sequenceSum);
            Console.WriteLine("The average = {0}", average);
        }
    }
}
