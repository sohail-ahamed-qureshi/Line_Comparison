using System;

namespace LineComparisionProblems
{
    class Program
    {/// <summary>
    /// Compare line lenghts and check line is greater/lesser/equal to other.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            LineComparing lineComparing = new LineComparing();
            lineComparing.CompareLines();
        }
    }
}
