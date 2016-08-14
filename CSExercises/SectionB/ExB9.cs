using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
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
            double roundedRes = Math.Ceiling(10*result) / 10;
            return roundedRes;

        }
    }
}
