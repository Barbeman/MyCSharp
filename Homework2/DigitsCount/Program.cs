//Яковлев Николай.
//Написать метод подсчета количества цифр числа.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace DigitsCount
    {
        class Program
        {
            static int DigitsCount(int n)
            {
                int count = 0;
                while (n != 0)
                {
                    n /= 10;
                    count++;
                }

                return count;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Давайте узнаем количество цифр в числе. Введите целое число.");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Количество цифр: {DigitsCount(number)}");
                Console.ReadKey();
            }
        }
    }
}