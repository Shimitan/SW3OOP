using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}