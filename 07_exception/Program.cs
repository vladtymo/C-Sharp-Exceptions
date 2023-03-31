using System;
using System.IO;

namespace _07_exception
{
    class Program
    {
        static void Main()
        {
            int a = 1, n = 2;

            try
            {
                // open connection
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Zero division.");
                Console.WriteLine("a / (2 - n) = {0}", a / (2 - n));
            }
            finally
            {
                // close connection
                Console.ResetColor();
                //Console.ForegroundColor = ConsoleColor.Gray;
                //Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("The End!");
            }

            Console.WriteLine("Press any key...");

            // Delay.
            Console.ReadKey();
        }
    }
}
