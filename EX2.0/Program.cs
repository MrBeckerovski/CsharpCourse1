using System;

namespace EX2._0
// Написать метод подсчета количества цифр числа.
// Беккер
{
    class Program
    {
        static void Main(string[] args)
        {
            static int SumNumb(int a)
            {
                int count = 0;
                while (a != 0)
                {
                    a = a / 10;
                    count++;
                }
                return count;
            }
        }
    }
}
