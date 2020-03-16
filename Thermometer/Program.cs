using System;

namespace Thermometer
{
    class Program
    {  
        static void Main(string[] args)
        {
            Thermometer thermometer = new Thermometer();
            thermometer.celciusToFahrenheit(32);
            Console.WriteLine("hasil : " + thermometer.result);

            thermometer.fahrenheitToCelcius(140);
            Console.WriteLine("hasil : " + thermometer.result);

            thermometer.celciusToKelvin(3);
            Console.WriteLine("hasil : " + thermometer.result);
        }
    }
}
