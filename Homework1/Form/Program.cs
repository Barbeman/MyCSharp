//Яковлев Николай.
//Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст,
//рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YakovlevClassLibrary;

namespace Yakovlev
{
    namespace Form
    {
        class Program
        {
            static void Main(string[] args)
            {                
                Console.WriteLine("Добрый день, пожалуйста заполните анкету.");
                Console.WriteLine("Введите ваше имя.");
                string name = Console.ReadLine();
                Console.WriteLine("Введите вашу фамилию.");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст полных лет.");
                string age = Console.ReadLine();
                Console.WriteLine("Введите ваш рост в м.");
                string height = Console.ReadLine();
                Console.WriteLine("Введите ваш вес в кг.");
                string weight = Console.ReadLine();

                //Console.WriteLine(name + " " + surname + "; " + age + " лет; " + height + " м. ростом; " + weight + " кг. веса.");
                //Console.WriteLine("{0} {1}; {2} лет; {3} м. ростом; {4} кг. веса.", name, surname, age, height, weight);

                Console.WriteLine($"{name} {surname}; {age} лет; {height} м. ростом; {weight} кг. веса.");

                //Console.ReadKey();
                Lib.Pause("Нажмите любую клавишу.");

            }
        }
    }
}
