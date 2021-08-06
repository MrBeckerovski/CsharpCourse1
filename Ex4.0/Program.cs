using System;

namespace Ex4._0
// Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
// Беккер
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string passwd;
            string login1 = "root";
            string passwd1 = "Geekbrains";
            int s = 3;                                                  
            do
            {
                Console.Write("Введите Ваш логин:");
                login = Console.ReadLine();
                Console.Write("Введите Ваш пароль:");
                passwd = Console.ReadLine();
                if (login1 == login)
                {
                    if (passwd == passwd1)
                    {
                        Console.WriteLine("Вход выполнен");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Пароль введен не верно");
                        --s;
                    }
                }
                else Console.WriteLine("Логин введен не верно");
                --s;
            }
            while (s > 0);
            if (s <= 0) Console.WriteLine("Вы превысили доступное количество попыток");
        }

    }
}
