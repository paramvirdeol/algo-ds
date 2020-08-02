using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Implementations
{
    public class BasicQueue<T>
    {
        private class Node
        {   
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data) 
            {
                this.Data = data;
            }
        }

        private Node _head;
        private Node _tail;

        public bool IsEmpty { get { return _head == null; } }
        public T Peek() 
        {
            return _head.Data;
        }
        public void Add(T data) 
        {
            Node node = new Node(data);
            if (_tail != null) {
                _tail.Next = node;
            }
            _tail = node;
            if (_head == null) {
                _head = node;
            }

        }
        public T Remove() {
            T data = _head.Data;
            _head = _head.Next;
            if (_head == null)
            {
                _tail = null;
            }
            return data;
        }
    }
}
