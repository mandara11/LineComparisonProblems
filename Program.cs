namespace LineComparisonProblem2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welome To Line Comparision Problem");
            int x1, x2, y1, y2;

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

            Length obj1 = new Length();
            obj1.LineLength(x1, x2, y1, y2);
        }
    }
}