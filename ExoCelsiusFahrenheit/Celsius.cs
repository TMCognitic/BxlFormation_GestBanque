using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCelsiusFahrenheit
{
    public struct Celsius
    {
        public static implicit operator Fahrenheit(Celsius value)
        {
            return new Fahrenheit() { Temperature = (value.Temperature * 1.8) + 32 };
        }

        public double Temperature { get; set; }
    }
}
