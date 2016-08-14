using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            double resultDbl = ConvertToFahrenheit(Convert.ToDouble(stringInput));
            Console.WriteLine(resultDbl);

        }

        public static double ConvertToFahrenheit(double c)
        {
            double result = 1.8 * c + 32;
            return result;

        }
    }
}
