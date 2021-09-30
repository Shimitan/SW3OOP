using System.Collections;
using System.Collections.Generic;

namespace InterfaceCar
{
    public class CompareCar : IComparer<Car>
    {
        int Compare(Car? x, Car? y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }
}