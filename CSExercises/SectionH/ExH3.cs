using System;

namespace CSExercises
{
    public class ExH3
    {
        //Write a function (static method) that would take in an integer and 
        //return the hexadecimal.  Print out the Hex of all numbers 1 to 100 and 
        //compare your answer with that of the built in function.

        public static void Main()
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Hex(num));

            for (int n = 0; n <= 100; n++)
            {
                Console.WriteLine("{0}\t{1}", n, Hex(n));
            }
        }
        public static string Hex(int i)
        {
            //We define this array because hexadecimal is a mixture of strings and numbers, so rather than an if/else statement, I'd rather map directly from an array
            //Note that this is a personal design decision, your implementation may vary

            string[] hexmapping = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };

            //Find the length of the expected hexadecimal; we intend to work backwards, decrementing and using the remainder to compute the remaining length of string
            //Can't work from smallest to largest because the base conversion algorithm requires that you remove descending powers of the base(base 10 -> base 16)
            //Basically, a for loop that tests if that power of 16 exceeds your input number, and updates your hexlength if not

            int hexlength = 0;

            for (int j = 0; Math.Pow(16, j) <= i; j++)
            {
                hexlength = j;
            }

            //Decrementing for loop; idea is to start from the back, removing 16^n each time and converting that into the corresponding hex from the hexmapping above
            //You can run an incrementing for loop, but make sure your power of 16 is (hexlength - current position)

            int remainder = i;
            string result = "";

            for (int hexPos = hexlength; hexPos >= 0; hexPos--)
            {
                //Power function returns a double, but we want a division to the nearest integer, remainder going into rest of hex string
                int divisor = Convert.ToInt32(Math.Pow(16, hexPos));
                int mappingIndex = remainder / divisor;
                //Append string to result
                result += hexmapping[mappingIndex];
                //Drop remainder by your computed power of 16; this forms the basis for the next sections of your string
                remainder -= mappingIndex * divisor;
            }

            return result;
        }
    }
}
