namespace LineComparisonProblem2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welome To Line Comparision Problem");
            int x1, x2, x3, x4, y1, y2, y3, y4;

            Console.WriteLine("Welcome to SINGLE LINE LENGTH PROGRAM");


            Console.WriteLine("Enter the coordinates value for points ");
            Console.WriteLine("Enter coordinate x for point1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate x for point2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point2");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coordinate x for point1 of Line2");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point1 of Line2");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate x for point2 of Line2");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point2 of Line2");
            y4 = Convert.ToInt32(Console.ReadLine());
            TwoLineCompare obj2 = new TwoLineCompare();
            obj2.TwoLineLength(x1, x2, x3, x4, y1, y2, y3, y4);

            //Length obj1 = new Length(); //UC1
            //obj1.LineLength(x1, x2, y1, y2);
        }
    }
}