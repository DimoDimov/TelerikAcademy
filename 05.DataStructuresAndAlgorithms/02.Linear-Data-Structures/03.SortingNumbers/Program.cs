namespace _03.SortingNumbers
{
    using System;
    using System.Collections.Generic;

    /*
     * Write a program that reads a sequence of integers 
     * (List<int>) ending with an empty line and sorts them 
     * in an increasing order.
     */

    class Program
    {
        static void Main()
        {
            List<int> numberContainer = new List<int>();

            Console.WriteLine("Please input the numbers to sort");

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == string.Empty)
                {
                    break;
                }

                int parsedNum;
                
                bool isParsed = int.TryParse(inputLine, out parsedNum);
               
                if (isParsed)
                {
                    numberContainer.Add(parsedNum);    
                }
            }

            numberContainer.Sort();

            Console.WriteLine(string.Join(" ",numberContainer));
        }
    }
}
