using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 5 to 10000.


    public class ExE5
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10000; i++)
            {
                string primeness = "not prime";
                if (ExE3.IsPrime(i))
                    primeness = "prime";
                Console.WriteLine("{0} is {1}", i, primeness);
            }


        }
    }
}
