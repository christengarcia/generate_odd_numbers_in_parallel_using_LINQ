/*
 *  C# Program to Generate Odd Numbers in Parallel using LINQ
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace generate_odd_numbers_in_parallel_using_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> oddNums = ((ParallelQuery<int>)ParallelEnumerable.Range(20, 2000))
            .Where(x => x % 2 != 0)
            .Select(i => i);
            foreach (int n in oddNums) { Console.WriteLine(n); }
            Console.ReadLine();
        }
    }
}
