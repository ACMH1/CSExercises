using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes a double precision number as input 
    //and prints the square of that number
    //For this exercise, you need to implement the square function
    //and handle the input and output in the Main method (use Exercise 2 as an example)

    public class ExA4
    {
        public static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            double inputDouble = Convert.ToDouble(stringInput);

            double result = square(inputDouble);

            Console.WriteLine(result);

        }

        public static double square(double x)
        {
            double result = Math.Pow(x, 2);
            return result;

        }
    }
}
