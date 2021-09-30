using System;
using System.Collections.Generic;

namespace InterfaceCar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){Make="Skoda", Model = "Fabia", Price = 60000},
                new Car(){Make="Skoda", Model = "Octavia", Price = 50000}
            };

            Console.WriteLine(cars[0].CompareTo(cars[1]));
            
            
            
            Console.WriteLine();
        }
    }
}