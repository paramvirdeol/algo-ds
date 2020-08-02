using HackerRank.DataStructures.Abstractions;
using HackerRank.DataStructures.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.DataStructures.Runners
{
    public class BasicStackRunner : IRunner
    {
        private readonly BasicStack _stack;
        public BasicStackRunner()
        {
            _stack = new BasicStack();
        }
        public void Run()
        {
            foreach (var item in Enumerable.Range(1,5))
            {
                _stack.Push(item);
            }
            var val = _stack.Peek();
            Utils.PrintResult(5, val);

            val = _stack.Pop();
            Utils.PrintResult(5, val);

            val = _stack.Pop();
            Utils.PrintResult(4, val);

            val = _stack.Pop();
            Utils.PrintResult(3, val);

            val = _stack.Pop();
            Utils.PrintResult(2, val);

            val = _stack.Pop();
            Utils.PrintResult(1, val);

            val = _stack.Pop();
            Utils.PrintResult(1, val);

        }
    }
}
