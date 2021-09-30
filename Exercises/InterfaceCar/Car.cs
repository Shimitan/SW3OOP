using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace InterfaceCar
{
    public class Car : IComparable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public int CompareTo(Car? other)
        {
            
            if (this.Price > other.Price)
            {
                return 1;
            }
            if (this.Price == other.Price)
            {
                return 0;
            }
            return -1;
        }
    }
}