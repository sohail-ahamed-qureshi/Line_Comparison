﻿using System;

namespace LineComparisionProblems
{
    class Program
    {/// <summary>
    /// Compare line lenghts and check line is greater/lesser/equal to other.
    /// Completing all use cases with oops concepts.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                LineComparing lineComparing = new LineComparing();
                lineComparing.CompareLines();
            }
            catch(Exception )
            {
                Console.WriteLine("Main program, Something went wrong!!");
            } 
        }
    }
}
