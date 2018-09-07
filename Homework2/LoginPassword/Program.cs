//Яковлев Николай.
//Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На
//выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
//GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
//вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
//цикла do while ограничить ввод пароля тремя попытками.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace LoginPassword
    {
        class Program
        {
            static bool PasswordCheck(string log, string psword)
            {
                if (log == "root" && psword == "GeekBrains")
                    return true;
                else
                    return false;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите логин и пароль. У вас есть три попытки.");
                string login = "";
                string password = "";
                bool check = false;
                //int count = 0;

                //do
                //{
                //    Console.WriteLine("Введите логин.");
                //    login = Console.ReadLine();
                //    Console.WriteLine("Введите пароль.");
                //    password = Console.ReadLine();
                //    check = PasswordCheck(login, password);
                //    if (check == true)
                //    {
                //        Console.WriteLine("Логин и пароль верный.");

                //        break;
                //    }
                //    else
                //    {
                //        count++;
                //        Console.WriteLine($"Вы ввели неправильный логин или пароль. Попробуйте еще раз. Оставшихся попыток: {3 - count}.");
                //    }
                //} while (count < 3);

                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Введите логин.");
                    login = Console.ReadLine();
                    Console.WriteLine("Введите пароль.");
                    password = Console.ReadLine();
                    check = PasswordCheck(login, password);
                    if (check == true)
                    {
                        Console.WriteLine("Логин и пароль верный.");

                        break;
                    }
                    else
                    {                        
                        Console.WriteLine($"Вы ввели неправильный логин или пароль. Попробуйте еще раз. Оставшихся попыток: {2 - i}.");
                    }
                }

                if (check == false) Console.WriteLine("Попытки закончились.");

                Console.ReadKey();
            }
        }
    }
}