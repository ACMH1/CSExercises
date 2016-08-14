using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges 
    //based on the kilometres travelled.
    //
    //Minimum fixed charge:  $2.40
    //In addition the fare would be computed at 40 cents per kilometer.
    //
    //E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

    public class ExB7
    {
        public static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            double resultDbl = CalculateFare(Convert.ToDouble(stringInput));
            Console.WriteLine(resultDbl);
        }

        public static double CalculateFare(double distance)
        {
            double result = 2.40 + 0.4 * distance;
            return result;

        }
    }
}
