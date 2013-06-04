namespace _06.Remove_Elements_That_Occur_Odd
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
     * Write a program that removes from given sequence all numbers 
     * that occur odd number of times. Example:
     * {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}
     */

    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Please input the sequence of integers separated by an interval: ");
            //string line = Console.ReadLine();

            string line =
                "4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2";

            Console.WriteLine("The list before the sorting: " + line);

            string[] elements = line.Split(',');

            List<int> originalList = new List<int>();

            //insert string line in List<int>
            foreach (var el in elements)
	        {
		        originalList.Add(int.Parse(el));
	        }

            Dictionary<int, int> newList = new Dictionary<int, int>();

            //count in dictionary how many elements 
            //have been met odd number of times
            foreach (var el in originalList)
            {
                if (!newList.Keys.Contains(el))
                {
                    newList.Add(el, 1);
                }
                else
                {
                    newList[el]++;
                }
            }

            //we remove all elements from the original list
            //that are being met odd number of times.
            foreach (KeyValuePair<int,int> pair in newList)
            {
                if (pair.Value % 2 != 0)
                {
                    originalList.RemoveAll(x => x == pair.Key);
                }
            }
            
            Console.Write("\nThe list after the sorting: ");
            
            //printing the sorted list
            foreach (var el in originalList)
            {
                Console.Write("{0}, ",el);
            }

            Console.WriteLine();
        }
    }
}
