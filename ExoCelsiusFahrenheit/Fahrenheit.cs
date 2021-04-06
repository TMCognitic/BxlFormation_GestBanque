using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCelsiusFahrenheit
{
    public struct Fahrenheit
    {
        public static explicit operator Celsius(Fahrenheit value)
        {
            return new Celsius() { Temperature = (value.Temperature - 32) / 1.8 };
        }

        public double Temperature { get; set; }
    }
}
