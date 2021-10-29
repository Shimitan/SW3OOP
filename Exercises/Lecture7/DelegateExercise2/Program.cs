using System;

namespace DelegateExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            private delegate string Join(string message1, string message2);

            private static string StringJoin(string message1, string message2, Join join)
            {
                return join(message1, message2);
            }

            private static string JoinThree(string message1, string message2, string message3, Join join)
            {
                string jointwo = join(message1, message2);
                return (join( message3));
            }
            
            static void Main(string[] args)
            {
                string message = StringJoin("Hello ", "World!", " Bob" ((message1, message2, message3) => message1 + message2, message3));
                Console.WriteLine(message);
            }
        }
    }
}