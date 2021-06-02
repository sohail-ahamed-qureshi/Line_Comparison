using System;

namespace LineComparisionProblems
{
    class Program
    {/// <summary>
    /// creating two objects of class to pass two diffrent lines.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            LineComparing lineComparing = new LineComparing();
            lineComparing.CompareLines();
            
        }
    }
}
