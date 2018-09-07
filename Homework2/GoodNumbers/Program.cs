//Яковлев Николай
//Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
//000. «Хорошим» называется число, которое делится на сумму своих цифр.Реализовать
//подсчёт времени выполнения программы, используя структуру DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace GoodNumbers
    {
        class Program
        {
            static void Main(string[] args)
            {
                DateTime start = DateTime.Now;
                Console.WriteLine("Программа вычисления хороших чисел от 1 до 1 000 000 000.");
                int goodNumbersCount = 0;
                for (int i = 1; i <= 1000000000; i++)
                {
                    int temp = 0;
                    int temp2 = i;
                    while (temp2 != 0)
                    {
                        temp += temp2 % 10;
                        temp2 /= 10;
                    }
                    if (i % temp == 0) goodNumbersCount++;
                }


                Console.WriteLine($"Количество хороших чисел в миллиарде: {goodNumbersCount}");
                DateTime finish = DateTime.Now;
                TimeSpan ts = finish - start;
                Console.WriteLine($"На выполнение функции ушло {ts}");
                Console.ReadKey();

            }
        }
    }
}