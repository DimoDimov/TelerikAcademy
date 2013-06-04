namespace _07.Elements_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
     * Write a program that finds in given array of integers 
     * (all belonging to the range [0..1000]) how many times each 
     * of them occurs.
     * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
     * 2  2 times
     * 3  4 times
     * 4  3 times
     */

    class Program
    {
        static void Main()
        {
            List<int> originalList = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Dictionary<int, int> countedElInDict = new Dictionary<int, int>();

            foreach (var el in originalList)
            {
                int value = 0;
                if (!countedElInDict.TryGetValue(el, out value))
                {
                    countedElInDict.Add(el, 1);
                }
                else
                {
                    countedElInDict[el]++;
                }
            }

            var keyList = countedElInDict.Keys.ToList();
            
            //we do sort the keyList, so we can have the 
            //key->value pairs returned by key value.
            keyList.Sort();

            foreach (var key in keyList)
            {
                Console.WriteLine("{0}->{1} times", key, countedElInDict[key]);
            }
        
        }
    }
}
