using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem2
{
        public  class LineCompare
        {
            public void IsEqul()
            {
                Console.WriteLine("enter x1,x2,y1,y2 values");
                double x1 = Convert.ToInt32(Console.ReadLine());
                double x2 = Convert.ToInt32(Console.ReadLine());
                double y1 = Convert.ToInt32(Console.ReadLine());
                double y2 = Convert.ToInt32(Console.ReadLine());
                double length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

                Console.WriteLine("enter x3,x4,y3,y4 values");
                double x3 = Convert.ToInt32(Console.ReadLine());
                double x4 = Convert.ToInt32(Console.ReadLine());
                double y3 = Convert.ToInt32(Console.ReadLine());
                double y4 = Convert.ToInt32(Console.ReadLine());
                double length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
                Console.WriteLine("length is equals or not : " + length1.Equals(length2));
            }
        }
}
