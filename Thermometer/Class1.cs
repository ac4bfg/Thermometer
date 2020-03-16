using System;

namespace Thermometer
{
    class Thermometer
    {
        public Double result;//
   
        public void celciusToFahrenheit(Double celcius) 
        {
            result = (celcius * 9 / 5) + 32;
        }

        public void fahrenheitToCelcius(int fahrenheit) {
            result = (fahrenheit - 32)* 5/9;
        }

        public void celciusToKelvin(float kelvin) {
            result = kelvin + 275.15;
        }
    }
}
