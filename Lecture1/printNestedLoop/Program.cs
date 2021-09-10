using System;

namespace printNestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j <= 5; j++)
            {
                Console.WriteLine(" ");
                for (int i = 0; i <= j; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}