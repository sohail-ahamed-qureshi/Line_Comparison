using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionProblems
{
    class FindLength
    {/// <summary>
    /// UC1 - solving for Length 
    /// length of a line = sqrt(x2 - x1)^2 + (y2 + y1)^2;
    /// </summary>
        readonly private int x1, x2, y1, y2;
        public FindLength(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public double Length()
        {
            double LengthOfLine;
            LengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return LengthOfLine;
        }
    }
}
