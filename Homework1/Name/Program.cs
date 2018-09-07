//Яковлев Николай
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakovlev
{
    namespace Name
    {
        class Program
        {
            static void Print(string msg, ConsoleColor color)
            {
                if (msg.Length <= Console.WindowWidth)
                {
                    Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.WindowHeight / 2);
                    Console.ForegroundColor = color;
                    Console.WriteLine(msg);
                }
                else
                {
                    Console.SetCursorPosition(Console.WindowLeft, Console.WindowHeight / 2);
                    Console.ForegroundColor = color;
                    Console.WriteLine(msg);
                }
            }
            static void Main(string[] args)
            {

                //Console.WriteLine("Меня зовут Николай Яковлев и я живу в пригороде г. Санкт-Петербурга.");

                //string message = "Меня зовут Николай Яковлев и я живу в пригороде г. Санкт-Петербурга.";
                //Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.WindowHeight / 2);
                //Console.WriteLine(message);

                Print("Меня зовут Николай Яковлев и я живу в пригороде г. Санкт-Петербурга.", ConsoleColor.Green);

                Console.ReadKey();
                                
            }
        }
    }
}
