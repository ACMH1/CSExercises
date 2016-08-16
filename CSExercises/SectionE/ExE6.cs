using System;

namespace CSExercises
{
    //Modify the Perfect Number C# program to print out 
    //all the perfect numbers from 1 to 1000.

    public class ExE6
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                string perfection = "not perfect";
                if (ExE4.IsPerfectNumber(i))
                    perfection = "perfect";
                Console.WriteLine("{0} is {1}", i, perfection);
            }



        }
    }
}
