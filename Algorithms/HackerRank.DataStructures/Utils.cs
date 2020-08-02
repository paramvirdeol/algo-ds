using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructures
{
    public static class Utils
    {
        public static void PrintResult(int expected, int actual)
        {
            if (expected == actual)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"Expected: {expected}, Actual: {actual}");
        }
        public static void PrintResult(bool expected, bool actual)
        {
            if (expected == actual)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"Expected: {expected}, Actual: {actual}");
        }

        public static void PrintError(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: " + errorMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
