namespace _08.Majorant_Of_An_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
     * The majorant of an array of size N is a value that occurs 
     * in it at least N/2 + 1 times. Write a program to find the 
     * majorant of given array (if exists). 
     * Example:{2, 2, 3, 3, 2, 3, 4, 3, 3}  3
     */

    class Program
    {
        static void Main(string[] args)
        {
            List<int> originalList = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            Dictionary<int, int> countedList = new Dictionary<int, int>();

            //for (int i = 0; i < originalList.Count; i++)
            //{
            //    int value = 0;
            //    if (!countedList.TryGetValue(countedList[i], out value))
            //    {
            //        countedList.Add(value, 1);
            //    }
            //    else
            //    {
            //        countedList[originalList[i]]++;
            //    }
            //}
            foreach (var el in originalList)
            {
                int value = 0;
                if (!countedList.TryGetValue(el, out value))
                {
                    countedList.Add(el, 1);
                }
                else
                {
                    countedList[el]++;
                }
            }

            var countedList2 = countedList.OrderBy(key => -key.Value);


            if (countedList2.First().Value >= ((originalList.Count / 2) + 1))
            {
                Console.WriteLine("{0} is a majorant of the given array",countedList2.First().Key);
            }
            else
            {
                Console.WriteLine("there is no majorant in the given array");
            }
        }
    }
}
