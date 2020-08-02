using HackerRank.DataStructures.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Runners
{
    public class QueueRunner : IRunner
    {
        private readonly IQueue<int> _queue;
        public QueueRunner(IQueue<int> queue)
        {
            _queue = queue;            
        }

        
        public void Run()
        {
            _queue.Enqueue(1);
            _queue.Enqueue(5);
            var val = _queue.Peek();
            Utils.PrintResult(1, val);            
            val = _queue.Peek();
            Utils.PrintResult(1, val);
            _queue.Enqueue(2);
            _queue.Enqueue(6);
            val = _queue.Peek();
            Utils.PrintResult(1, val);
            val = _queue.Dequeue();
            Utils.PrintResult(1, val);
            val = _queue.Dequeue();
            Utils.PrintResult(5, val);
            val = _queue.Dequeue();
            Utils.PrintResult(2, val);
            val = _queue.Dequeue();
            Utils.PrintResult(6, val);
            val = _queue.Dequeue();
            Utils.PrintResult(6, val);
            //val = _queue.Dequeue();
            //Console.WriteLine($"Expected: 1, Actual: {val}");


        }

    }
}
