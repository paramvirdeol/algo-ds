using HackerRank.DataStructures.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Implementations
{
    public class SelfStringBalanceValidator : IStringBalanceValidator
    {
        public bool IsBalanced(string expression)
        {
            Stack<char> currentStack = new Stack<char>();
            for (int i = 0; i < expression.Length; i++)
            {
                var val = expression[i];
                if (currentStack.Count == 0)
                {
                    currentStack.Push(val);
                }
                else
                {
                    var prevVal = currentStack.Peek();
                    if (prevVal == '{' && val == '}') currentStack.Pop();
                    else if (prevVal == '(' && val == ')') currentStack.Pop();
                    else if (prevVal == '[' && val == ']') currentStack.Pop();
                    else currentStack.Push(val);
                }

            }
            return currentStack.Count == 0;
        }
    }
}
