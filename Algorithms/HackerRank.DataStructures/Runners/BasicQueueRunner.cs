using HackerRank.DataStructures.Abstractions;
using HackerRank.DataStructures.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.DataStructures.Runners
{
    public class BasicQueueRunner : IRunner
    {
        private readonly BasicQueue<int> _queue;
        public BasicQueueRunner()
        {
            _queue = new BasicQueue<int>();
        }
        public void Run()
        {
            var range = Enumerable.Range(5, 5);
            foreach (var data in range)
            {
                _queue.Add(data);
            }
            var val = _queue.Peek();
            Utils.PrintResult(5, val);
            val = _queue.Remove();
            Utils.PrintResult(5, val);
            val = _queue.Remove();
            Utils.PrintResult(6, val);
            val = _queue.Remove();
            Utils.PrintResult(7, val);
            val = _queue.Remove();
            Utils.PrintResult(8, val);
            _queue.Add(20);
            val = _queue.Remove();
            Utils.PrintResult(9, val);            
            val = _queue.Remove();
            Utils.PrintResult(20, val);

        }
    }
}
