using HackerRank.DataStructures.Abstractions;
using HackerRank.DataStructures.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures.Runners
{
    public class BSTInOrderRunner : IRunner
    {
        public void Run()
        {
            BSTNode tree = new BSTNode(10);
            tree.Insert(15);
            tree.Insert(5);
            tree.Insert(8);

            Console.Write("PrintInOrder : ");
            tree.PrintInOrder();
            Console.WriteLine();
            
            Console.Write("PrintPreOrder : ");
            tree.PrintPreOrder();
            Console.WriteLine();

            Console.Write("PrintPostOrder : ");
            tree.PrintPostOrder();
            Console.WriteLine();
            var result = tree.Contains(8);
            Utils.PrintResult(true, result);
        }
    }
}
