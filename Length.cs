﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem2
{
    public class Length
    {
        public void LineLength(int x1, int x2, int y1, int y2)
        {
            double length = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2));
            Console.WriteLine("Length of line is : {0} units", length);
        }
    }
}
