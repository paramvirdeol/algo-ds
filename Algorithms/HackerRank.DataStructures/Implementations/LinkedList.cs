using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Implementations
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
        }        
    }

    public class LinkedList
    {
        public Node Head { get; private set; }
        public void Append(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
                return;
            }
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(data);            
        }

        public void Prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.Next = Head;
            Head = newHead;
        }

        public void DeleteWithValue(int data)
        {
            if (Head == null) return;
            if (Head.Data == data)
            {
                Head = Head.Next;
                return;                
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
    }
}
