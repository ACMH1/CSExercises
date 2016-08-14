using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Slight modification to above: Write a program that 
    //takes a double precision number as input and prints 
    //the square root of the number.  
    //The square root should be rounded to 3 decimal places.
    //Input	    Output
    //0	        0.000
    //25	    5
    //3	        1.732
    //300	    17.321

    public class ExB2
    {
        public static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            double inputDouble = Convert.ToDouble(strInput);

            Console.WriteLine(SQRT(inputDouble));
        }

        public static string SQRT(double x)
        {
            double result = Math.Round(Math.Sqrt(x), 3);
            string strResult = Convert.ToString(result);
            return strResult;

        }
    }
}
