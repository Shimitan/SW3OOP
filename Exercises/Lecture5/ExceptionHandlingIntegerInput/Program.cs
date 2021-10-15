using System;

namespace ExceptionHandlingIntegerInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            string intnumber = Console.ReadLine();

            try
            {
                Int32.Parse(intnumber);
            }
            catch (Exception e)
            {
                Console.WriteLine("Your input was not an integer");
                throw;
            }
            Console.WriteLine("Your inputted integer is: " + intnumber);
        }
    }
}