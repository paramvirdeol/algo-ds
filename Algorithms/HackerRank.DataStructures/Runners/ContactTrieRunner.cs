using HackerRank.DataStructures.Abstractions;
using HackerRank.DataStructures.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Runners
{
    public class ContactTrieRunner : IRunner
    {
        public void Run()
        {
            TrieNode node = new TrieNode();
            node.Add("gayle");
            node.Add("gary");
            node.Add("geera");
            node.Add("alex"); 
            node.Add("andy");

            var result = node.FindCount("ga", 0);
            Utils.PrintResult(2, result);
        }

        
    }
}
