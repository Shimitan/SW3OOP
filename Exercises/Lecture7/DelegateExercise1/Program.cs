using System;
using System.Threading.Channels;

namespace DelegateExercise1
{
    class Program
    {
        private delegate string Join(string message1, string message2);

        private static string DelegateMethod(string message1, string message2, Join join)
        {
            return join(message1, message2);
        }
        
        static void Main(string[] args)
        {
            string message = DelegateMethod("Hello ", "World!", ((message1, message2) => message1 + "." + message2));
            Console.WriteLine(message);
        }
    }
}