using HackerRank.DataStructures.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Implementations
{
    /// <summary>
    /// This is a slightly modified version of StringBalanceValidator that makes use of dictionary
    /// </summary>
    public class HackerRankStringBalanceValidator : IStringBalanceValidator
    {
        public static Dictionary<char, char> TOKENS = new Dictionary<char, char>
        {
             { '{', '}' }, { '(', ')' }, { '[', ']' }
        };
        public static bool IsOpenTerm(char c)
        {
            return TOKENS.ContainsKey(c);
        }

        public static bool Matches(char openTerm, char closeTerm)
        {
            return TOKENS[openTerm] == closeTerm;
        }
        public bool IsBalanced(string expression)
        {            
            Stack<char> stack = new Stack<char>();
            foreach (char c in expression.ToCharArray())
            {
                if (IsOpenTerm(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0 || !Matches(stack.Pop(), c))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
