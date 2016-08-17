using System;

namespace CSExercises
{
    //Write a C# program that would sort a numeric array in descending order 
    //using the simplified selection sort method described.

    //At the end of each pass print out the array to know the progress!

    public class ExF2
    {
        public static void Main(string[] args)
        {
            int[] list = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            Sort(list);

            for (int k = 0; k < list.Length; k++)
            {
                Console.Write(list[k] + " ");
            }
            Console.WriteLine();
        }

        public static void Sort(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] > values[j])
                    {
                        int tmp = values[i];
                        values[i] = values[j];
                        values[j] = tmp;
                    }
                }
                Console.WriteLine("{0} ({1})", StrArray(values), i);
            }
        }

        public static string StrArray(int[] arr)
        {
            string result = "{";
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                if (i < arr.Length - 1)
                    result += ", ";
            }
            result += "}";
            return result;

        }
    }
}
