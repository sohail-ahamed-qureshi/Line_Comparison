using System;

namespace LineComparisionProblems
{
    class Program
    {/// <summary>
    /// Welcomr message for Line Comparison problemstatements.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            FindLength findLength = new FindLength(-7, 17, -4, 6);
            Console.WriteLine($"Length of the line is : {findLength.Length()}");
        }
    }
}
