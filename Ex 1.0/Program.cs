using System;


namespace Ex_1._0
// Написать метод, возвращающий минимальное из трёх чисел.
// Беккер
{
    class Program
    {
        static void Main(string[] args)
        { 
            static int MinNum3(int a, int b, int c)
            {
                if (a <= b && a <= c)
                {
                    return a;
                }
                else if (b <= c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }
    }
}