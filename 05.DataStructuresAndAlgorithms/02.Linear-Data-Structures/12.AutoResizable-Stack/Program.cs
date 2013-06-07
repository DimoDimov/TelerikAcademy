using System;
using System.Linq;


namespace _12.AutoResizable_Stack
{
    /*
     * Implement the ADT stack as auto-resizable array. 
     * Resize the capacity on demand (when no space is available to 
     * add / insert a new element).
     */

    class Program
    {
        static void Main()
        {
            StackImplementaton<int> stackImp = new StackImplementaton<int>();

            stackImp.Push(3);
            Console.WriteLine(stackImp.Capacity());
            stackImp.TrimExcess();
            Console.WriteLine(stackImp.Capacity());

            stackImp.Push(4);
            Console.WriteLine(stackImp.Capacity());
            Console.WriteLine(stackImp.Count);

            stackImp.Push(5);
            Console.WriteLine(stackImp.Capacity());
            Console.WriteLine(stackImp.Count);
            stackImp.Pop();
            Console.WriteLine(stackImp.Count);

        }
    }
}
