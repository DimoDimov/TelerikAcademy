namespace _11.LinkedList_Implementation
{
    using System;
    using System.Linq;

    /*
     * Implement the data structure linked list. Define a class ListItem<T> 
     * that has two fields: value (of type T) and 
     * NextItem (of type ListItem<T>). Define additionally a 
     * class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
     */
    
    class Program
    {
        static void Main()
        {
            LinkedListImp<int> linkedList = new LinkedListImp<int>();

            linkedList.AddFirst(15);
            linkedList.AddLast(110);
            linkedList.AddFirst(10);
            linkedList.AddFirst(5);
            linkedList.AddLast(235);

            ListItem<int> afterForthEl = linkedList.FirstElement.NextItem.NextItem.NextItem;
            linkedList.AddAfter(afterForthEl, 111);

            ListItem<int> beforeForthEl = linkedList.FirstElement.NextItem.NextItem.NextItem;
            linkedList.AddBefore(beforeForthEl, 109);
           
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            ListItem<int> next = linkedList.FirstElement;
            while (next != null)
            {
                Console.WriteLine(next.Value);
                next = next.NextItem;
            }

            Console.WriteLine("Count of the group {0}",linkedList.Count);
        }
    }
}
