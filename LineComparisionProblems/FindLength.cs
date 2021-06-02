using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionProblems
{
    public abstract class LineComparisionComputation
    {
        public abstract double Length();
    }
    class FindLength : LineComparisionComputation
    {/// <summary>
    /// UC3 - After Solving length of line checking if lines are Equal/greater/lesser to otherdsf.
    /// length of a line = sqrt(x2 - x1)^2 + (y2 + y1)^2;
    /// scope of variables is limited to this class.
    /// </summary>
        readonly private int x1, x2, y1, y2;
         private double LengthOfLine;
        public FindLength(int x1, int x2, int y1, int y2)
        {
                this.x1 = x1;
                this.x2 = x2;
                this.y1 = y1;
                this.y2 = y2;
        }

        public override double Length()
        {
            try
            {
                LengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return LengthOfLine;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Length of line calculation");
            }
            return 0;
        }
    }
}
