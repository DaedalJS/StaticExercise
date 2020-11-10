using System;

namespace StaticExercise
{
    class Program
    {   
        public static double FahrenheightToCelsius(double f)
        {
            double c = (f - 32) / 1.8;
            return c;
        }
        public static double CelsiusToFahrenheight(double c)
        {
            double f = c * 1.8 + 32;

            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("give us a number.");
            double t;
            while (!double.TryParse(Console.ReadLine(), out t)) { Console.WriteLine("give us a number"); }

            Console.WriteLine($"when converting to Celsius {t}f becomes {FahrenheightToCelsius(t)}c.");
            Console.WriteLine($"when converting to Fahrenheight {t}c becomes {CelsiusToFahrenheight(t)}f.");
        }
    }
}
