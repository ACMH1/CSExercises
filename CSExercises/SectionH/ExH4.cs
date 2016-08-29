using System;


namespace CSExercises
{
    //Write a static method:  Substitute(string s, char c1, char c2) that would
    //return a string. The method should find all occurrences of the character c1
    //in the string s and substitute c1 with character c2.  The new word so formed would
    //be the return value of this method.
    public class ExH4
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                    result += c2;
                else
                    result += s[i];
            }
            return result;
        }
        public static void Main()
        {
            Console.Write("String to be altered: ");
            string s1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Working character: ");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Substitute with: ");
            char c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(Substitute(s1, c1, c2));
        }
    }
}