using HackerRank.DataStructures.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Implementations
{
    /// <summary>
    /// Implementing queue using two stacks
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HRQueue<T> : IQueue<T>
    {
        private readonly Stack<T> stackNewestOnTop = new Stack<T>();
        private readonly Stack<T> stackOldestOnTop = new Stack<T>();

        public void Enqueue(T value)
        {
            stackNewestOnTop.Push(value);
        }
        public T Peek()
        {
            ShiftStacks();
            return stackOldestOnTop.Peek();
        }
        public T Dequeue()
        {
            ShiftStacks();
            if (stackOldestOnTop.Count == 0) {
                throw new InvalidOperationException("Queue is empty");
            }
            return stackOldestOnTop.Pop();
        }

        private void ShiftStacks()
        {
            if (stackOldestOnTop.Count == 0)
            {
                while (stackNewestOnTop.Count != 0)
                {
                    stackOldestOnTop.Push(stackNewestOnTop.Pop());
                }
            }
        }


    }
}
