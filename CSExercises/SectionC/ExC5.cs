using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            int intInput = Convert.ToInt32(strInput);
            bool result = IsArmstrongNumber(intInput);
            Console.WriteLine(result);
        }


        public static bool IsArmstrongNumber(int n)
        {
            int firstDigit = n / 100;
            int secondDigit = (n - firstDigit * 100) / 10;
            int thirdDigit = n - firstDigit * 100 - secondDigit * 10;

            int armstrongSum =    Convert.ToInt32(Math.Pow(firstDigit, 3)) 
                                + Convert.ToInt32(Math.Pow(secondDigit, 3)) 
                                + Convert.ToInt32(Math.Pow(thirdDigit, 3));
            if (armstrongSum == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}