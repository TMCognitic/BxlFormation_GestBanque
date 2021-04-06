using System;

namespace ExoCelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius() { Temperature = 30 };
            Console.WriteLine($"Température en Celsius : {c.Temperature}");
            Fahrenheit f = c; //Utilise la surcharge d'opérateur de cast implicite
            Console.WriteLine($"Température en Fahrenheit : {f.Temperature}");
            c = (Celsius)f; //Utilise la surcharge d'opérateur de cast explicite
            Console.WriteLine($"Température en Celsius : {c.Temperature}");
        }
    }
}
