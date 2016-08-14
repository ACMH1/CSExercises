using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            double resultDbl = CalculateFare(Convert.ToDouble(stringInput));
            Console.WriteLine("{0:#,##0.0}0", resultDbl);
        }

        public static double CalculateFare(double distance)
        {
            double resultDbl = 2.40 + 0.4 * distance;
            double result = 2.40 + 0.4 * distance;
            return result;

        }
    }
}
