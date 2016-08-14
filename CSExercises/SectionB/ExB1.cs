using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            double inputDouble = Convert.ToDouble(strInput);

            Console.WriteLine(SQRT(inputDouble));
        }

        public static double SQRT(double x)
        {
            double result = Math.Sqrt(x);
            return result;

        }
    }
}
