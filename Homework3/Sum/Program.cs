//Яковлев Николай.
//С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму
//вывести на экран, используя tryParse.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yakovlev
{
    namespace Sum
    {
        class Program
        {
            static int ReadPlusTest()
            {
                bool flag = true;
                int n;
                do
                {
                    flag = int.TryParse(Console.ReadLine(), out n);
                    if (!flag) Console.WriteLine("Ошибка, вы ввели неправильные данные, попробуйте еще раз.");
                } while (!flag);
                return n;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Проверка GIT эйэй. Посчитаем сумму введенных нечетных положительных чисел. Результат будет выведен на экран при вводе нуля.");
                int n = -10, sum = 0;
                string numbers = "";
                while (n != 0)
                {
                    Console.Write("Введите число. ");
                    n = ReadPlusTest();
                    if (n > 0 && n%2 != 0)
                    {
                        sum += n;
                        numbers += $" {n.ToString()}";
                    }
                }

                Console.WriteLine($"Числа: {numbers}; сумма всех нечетных положительных чисел равна: {sum}.");
                Console.ReadKey();
            }
        }
    }
}