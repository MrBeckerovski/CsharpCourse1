using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Ваша ваш рост (м,)?");
			double height = Double.Parse(Console.ReadLine());

			Console.WriteLine("Ваша ваш вес (кг,)?");
			double weight = Double.Parse(Console.ReadLine());

			double bmi = weight / (height * height);

			Console.WriteLine("Ваш индекс массы тела: " + bmi.ToString("N2"));














		}
    }
}
