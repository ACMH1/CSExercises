using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {

            string distanceStr = Console.ReadLine();
            double distanceDbl = Convert.ToDouble(distanceStr);
            Console.WriteLine("${0:0.00}", CalculateFare(distanceDbl));

        }

        public static double CalculateFare(double distance)
        {
            double result = 2.4;

            if (distance > 0.5 && distance <= 9)
            {
                result = result + 0.04 * Math.Ceiling((distance - 0.5) * 10);
            }
            if (distance > 9)
            {
                result = result + 0.4 * 8.5 + 0.05 * Math.Ceiling((distance - 9) * 10);
            }

                return result;



        }
    }
}