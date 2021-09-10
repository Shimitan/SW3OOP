using System;

namespace convertDegRad
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = 100;
            double radians;
            
            Console.WriteLine(degrees);
            radians = degrees * (Math.PI / 180);
            Console.WriteLine(radians);
            degrees = radians * (180 / Math.PI);
            Console.WriteLine(degrees);
        }
    }
}