using HackerRank.DataStructures.Abstractions;
using HackerRank.DataStructures.Implementations;
using HackerRank.DataStructures.Runners;
using System;
using System.Collections.Generic;

namespace HackerRank.DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var actionsToBeTested = new Dictionary<string, Action>();
            //actionsToBeTested.Add("Testing if the string is balanced", () =>
            //{
            //    IStringBalanceValidator validator = new HackerRankStringBalanceValidator();
            //    var runner = new StringBalanceValidatorRunner(validator);
            //    runner.Run();
            //});

            //actionsToBeTested.Add("Testing Queue with Two Stacks", () =>
            //{
            //    IQueue<int> queue = new HRQueue<int>();
            //    var runner = new QueueRunner(queue);
            //    runner.Run();
            //});

            //actionsToBeTested.Add("Basic queue using linked list", () =>
            //{                
            //    var runner = new BasicQueueRunner();
            //    runner.Run();
            //});

            //actionsToBeTested.Add("Basic stack using linked list", () =>
            //{
            //    var runner = new BasicStackRunner();
            //    runner.Run();
            //});

            //actionsToBeTested.Add("Detecting cycles in a linked list", () =>
            //{
            //    var runner = new CycleDetectionRunner();
            //    runner.Run();
            //});

            //actionsToBeTested.Add("Iterating a linked list", () =>
            //{
            //    var runner = new LinkedListRunner();
            //    runner.Run();
            //});

            //actionsToBeTested.Add("Iterating a Binary Search Tree", () =>
            //{
            //    var runner = new BSTInOrderRunner();
            //    runner.Run();
            //});

            actionsToBeTested.Add("Searching strings using tries", () =>
            {
                var runner = new ContactTrieRunner();
                runner.Run();
            });


            foreach (var item in actionsToBeTested)
            {
                RunAlgo(item.Key, item.Value);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void RunAlgo(string message, Action action)
        {
            Console.WriteLine(message);
            Console.WriteLine("===========================================================");
            try
            {
                action();
            }
            catch (InvalidOperationException ex)
            {
                Utils.PrintError(ex.Message);                
            }
            Console.WriteLine("===========================================================");
            Console.WriteLine();
        }
    }
}
