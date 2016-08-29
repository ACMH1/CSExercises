using System;

namespace CSExercises
{
    public class ExH1
    {
        public static void Main()
        {
            Console.Write("S1: ");
            string s1 = Console.ReadLine();
            Console.Write("S2: ");
            string s2 = Console.ReadLine();

            Console.WriteLine(InString(s1, s2));
        }
        public static bool InString(string s1, string s2)
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
                        {
                            stringMatch = false;
                            break;
                        }
                    }
                    if (stringMatch == true)
                        return true;
                }
            }
            return false;
        }
    }
}
