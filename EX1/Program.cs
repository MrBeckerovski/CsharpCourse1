using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут? : ");
            var name = Console.ReadLine();
            Console.WriteLine("Какая у вас фамилия? : ");
            var family = Console.ReadLine();
            Console.WriteLine("Сколько вам лет? : ");
            var age = Console.ReadLine();
            Console.WriteLine("Какого вы роста? : ");
            var height = Console.ReadLine();
            Console.WriteLine("Сколько вы весите? : ");
            var weight = Console.ReadLine();
            var sum = name + family + age + height + weight;
            Console.WriteLine($"{name} + {family} + {age} + {height} + {weight} = {sum}");
        }
    }
}
    
