using System;
using LinkedListImplem;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();

            list.PushBack(1);
            list.PushBack("Test2");
            list.PushBack(3.2m);
            

            int count = list.GetCount();
            for(int i = 0; i < count; ++i)
            {
                Console.Write("Element at " + i + " has the value:" + list.GetAt(i));
            }
        }
    }
}
