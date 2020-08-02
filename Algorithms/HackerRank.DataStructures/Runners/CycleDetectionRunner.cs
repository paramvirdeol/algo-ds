using HackerRank.DataStructures.Abstractions;
using HackerRank.DataStructures.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.DataStructures.Runners
{
    public class CycleDetectionRunner : IRunner
    {
        public void Run()
        {
            CycleDetection cycleDetection = new CycleDetection();
            var cyclicalList = GetCyclicList();
            var result = cycleDetection.HasCycle(cyclicalList);
            Utils.PrintResult(true, result);

            var nonCyclicalList = GetNonCyclicList();
            result = cycleDetection.HasCycle(nonCyclicalList);
            Utils.PrintResult(false, result);

        }

        private Node GetCyclicList()
        {
            Node head = new Node(1);
            Node linkedList = head;
            foreach (var number in Enumerable.Range(2, 9))
            {
                Node node = new Node(number);
                linkedList.Next = node;
                linkedList = node;
            }
            linkedList.Next = head;
            return head;
        }

        private Node GetNonCyclicList()
        {
            Node head = new Node(1);
            Node linkedList = head;
            foreach (var number in Enumerable.Range(2, 9))
            {
                Node node = new Node(number);
                linkedList.Next = node;
                linkedList = node;
            }
            
            return head;
        }
    }
}
