using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to convert to Fahrenheit or Celsius?");
           var unitChosen = Console.ReadLine();

            if (unitChosen == "Fahrenheit")

            {
                Console.WriteLine("Which temperature in Celsius to you need to convert?");
                string celsius = Console.ReadLine();
                double celsiusD = double.Parse(celsius);
                TempConverter.CelsiusToFahrenheit(celsiusD);
            }
            else
            {
                Console.WriteLine("Which temperature in Fahrenheit to you need to convert?");
                string fahrenheit = Console.ReadLine();
                double fahrenheitD = double.Parse(fahrenheit);
                TempConverter.FahrenheitToCelsius(fahrenheitD);
            }

                
        }
    }
}
