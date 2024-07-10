using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * (5 / 9);
            Console.WriteLine($"Here is the equivalant in Celsius: {celsius}");
            return celsius;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * (9 / 5)) + 32;
            Console.WriteLine($"Here is the equivalant in Fahrenheit: {fahrenheit}");
            return fahrenheit;

        }


    }
}
