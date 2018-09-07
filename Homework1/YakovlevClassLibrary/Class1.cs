using System;

namespace YakovlevClassLibrary
{
    public class Lib
    {
        public static void Print(string msg, ConsoleColor color)
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

        public static void Print(string msg, int x, int y)
        {
           
            Console.SetCursorPosition(x, y);               
            Console.WriteLine(msg);            
        }

        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void Pause(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
