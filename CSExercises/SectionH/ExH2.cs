using System;

namespace CSExercises
{
    public class ExH2
    {
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.

        public static void Main()
        {
            Console.Write("S1: ");
            string s1 = Console.ReadLine();
            Console.Write("S2: ");
            string s2 = Console.ReadLine();

            Console.WriteLine(FindWord(s1, s2));
        }

        public static int FindWord(string s1, string s2)
        {
            string s1Lower = s1.ToLower();
            string s2Lower = s2.ToLower();

            for (int startPos = 0; startPos <= s1.Length - s2.Length; startPos++)
            {
                if (s1Lower[startPos] == s2Lower[0])
                {
                    bool stringMatch = true;
                    for (int testPos = 1; testPos < s2.Length; testPos++)
                    {
                        if (s1Lower[startPos + testPos] != s2Lower[testPos])
                            stringMatch = false;
                        break;
                    }
                    if (stringMatch == true)
                        return startPos;
                }
            }
            return -1;
        }
    }
}
