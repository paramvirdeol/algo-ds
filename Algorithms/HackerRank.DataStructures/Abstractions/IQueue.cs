using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Abstractions
{
    public interface IQueue<T>
    {
        void Enqueue(T value);
        T Peek();
        T Dequeue();
    }
}
