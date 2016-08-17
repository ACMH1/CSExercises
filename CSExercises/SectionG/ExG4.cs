using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            string[] nameArr = new string[]
            {
                "John",
                "Venkat",
                "Mary",
                "Victor",
                "Betty"
            };

            int[] marksArr = new int[]
            {
                63,
                29,
                75,
                82,
                55
            };

            //Console.WriteLine(string.Join("\n", nameArr));
            //Console.WriteLine(string.Join("\n", marksArr));

            string[] nameSort = StringSort(nameArr);
            int[] markSort = IntSort(marksArr);

            //Console.WriteLine(string.Join("\n", nameSort));
            //Console.WriteLine(string.Join("\n", markSort));

            //Console.WriteLine(string.Join("\n", nameArr));
            //Console.WriteLine(string.Join("\n", marksArr));

            //Generate paired report sorted by name

            Console.WriteLine("Name(s)\t\tMark");
            for (int i = 0; i < nameSort.Length; i++)
            {
                for (int j = 0; j < nameArr.Length; j++)
                {
                    if (nameSort[i] == nameArr[j])
                    {
                        Console.WriteLine("{0}\t\t{1}", nameSort[i], marksArr[j]);
                    }
                }
            }

            Console.WriteLine("\n\n\n");

            //Generate paired report sorted by marks

            Console.WriteLine("Name\t\tMark(s)");
            for (int i = 0; i < markSort.Length; i++)
            {
                for (int j = 0; j < marksArr.Length; j++)
                {
                    if (markSort[i] == marksArr[j])
                    {
                        Console.WriteLine("{0}\t\t{1}", nameArr[j], markSort[i]);
                    }
                }
            }

        }

        public static string[] StringSort(string[] strArr)
        {
            string[] result = new string[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                result[i] = strArr[i];
            }
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i].CompareTo(result[j]) > 0)
                    {
                        string tmp = result[i];
                        result[i] = result[j];
                        result[j] = tmp;
                    }
                }
                //Console.WriteLine(result[i]);
            }
            //Console.WriteLine(result[result.Length - 1]);
            return result;
        }

        public static int[] IntSort(int[] intArr)
        {
            int[] result = new int[intArr.Length];
            for (int i = 0; i < intArr.Length; i++)
            {
                result[i] = intArr[i];
            }
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i].CompareTo(result[j]) < 0)
                    {
                        int tmp = result[i];
                        result[i] = result[j];
                        result[j] = tmp;
                    }
                }
                //Console.WriteLine(result[i]);
            }
            //Console.WriteLine(result[result.Length - 1]);
            return result;
        }
    }
}
