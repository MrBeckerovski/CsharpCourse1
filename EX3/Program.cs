using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x1 = 0; 
            Double x2 = 0;
            Double y1 = 0;
            Double y2 = 0;
            Double distance;
           
            Console.Write("x1=");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("x2=");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y1=");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("y2=");
            y2 = double.Parse(Console.ReadLine());

            {
                distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
                
                Console.WriteLine("distance:" + "{0:F2}", distance);
                Console.ReadLine();





            }
        }
    }
}
