using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionProblems
{
    class LineComparing
    {/// <summary>
     /// Comparing 2 lines and displaying message if equals
     /// </summary>


        public void CompareLines()
        {
            FindLength findLength1 = new FindLength(-7, 17, -4, 6);
            FindLength findLength2 = new FindLength(-7, 17, -4, 6);
            double LengthOfLine1 = findLength1.Length();
            double LengthOfLine2 = findLength2.Length();

            if (LengthOfLine1 == LengthOfLine2)
            {
                Console.WriteLine($"Length of line1 {LengthOfLine1} == Length of Line2 {LengthOfLine2}");
            }
            else
            {
                Console.WriteLine($"Length of line 1 {LengthOfLine1} != Length of Line 2 {LengthOfLine2}");
            }
        }
    }
}
