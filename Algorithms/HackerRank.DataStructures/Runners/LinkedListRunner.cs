using HackerRank.DataStructures.Abstractions;
using HackerRank.DataStructures.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Runners
{
    public class LinkedListRunner : IRunner
    {
        public void Run()
        {
            var myList = new LinkedList();
            PrintList(myList);
            myList.Append(2);
            PrintList(myList);
            myList.Append(3);
            PrintList(myList);
            myList.Append(4);
            PrintList(myList);
            myList.DeleteWithValue(3);
            PrintList(myList);
            myList.Prepend(5);
            PrintList(myList);
            myList.DeleteWithValue(5);
            PrintList(myList);
            myList.Append(7);
            PrintList(myList);
        }

        private void PrintList(LinkedList list)
        {
            if (list.Head == null) Console.WriteLine("Empty List");
            Node current = list.Head;
            Console.Write("Printing list: ");
            while (current!=null)
            {
                Console.Write(current.Data + ",");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
