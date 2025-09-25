using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionMeteo
{
    static class Convertisseur
    {
        public static double ConvertToF(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ConvertToC(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
