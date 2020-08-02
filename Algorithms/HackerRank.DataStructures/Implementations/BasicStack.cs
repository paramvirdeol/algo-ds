using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Implementations
{
    public class BasicStack 
    {
        private class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
            }
        }

        private Node _top;
        public bool IsEmpty { get { return _top == null; } }

        public int Peek()
        {
            return _top.Data;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            node.Next = _top;
            _top = node;
        }
        public int Pop()
        {
            if (_top == null) throw new InvalidOperationException("Stack is empty");
            int data = _top.Data;
            _top = _top.Next;
            return data;
        }
    }
}
