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

            //PrintArrays(nameArr, marksArr);
            IntSort(nameArr, marksArr);
            PrintArrays(nameArr, marksArr);

            StringSort(nameArr, marksArr);
            PrintArrays(nameArr, marksArr);

        }

        public static void StringSort(string[] nameArr, int[] marksArr)
        {
            for (int nameIndex1 = 0; nameIndex1 < nameArr.Length - 1; nameIndex1++)
            {
                for (int nameIndex2 = nameIndex1 + 1; nameIndex2 < nameArr.Length; nameIndex2++)
                {
                    if (nameArr[nameIndex1].CompareTo(nameArr[nameIndex2]) > 0)
                    {
                        string tmp = nameArr[nameIndex1];
                        nameArr[nameIndex1] = nameArr[nameIndex2];
                        nameArr[nameIndex2] = tmp;

                        int tmpnum = marksArr[nameIndex1];
                        marksArr[nameIndex1] = marksArr[nameIndex2];
                        marksArr[nameIndex2] = tmpnum;
                    }
                }
            }
        }

        public static void IntSort(string[] nameArr, int[] marksArr)
        {
            for (int marksIndex1 = 0; marksIndex1 < marksArr.Length - 1; marksIndex1++)
            {
                for (int marksIndex2 = marksIndex1 + 1; marksIndex2 < marksArr.Length; marksIndex2++)
                {
                    if (marksArr[marksIndex1] < marksArr[marksIndex2])
                    {
                        string tmp = nameArr[marksIndex1];
                        nameArr[marksIndex1] = nameArr[marksIndex2];
                        nameArr[marksIndex2] = tmp;

                        int tmpnum = marksArr[marksIndex1];
                        marksArr[marksIndex1] = marksArr[marksIndex2];
                        marksArr[marksIndex2] = tmpnum;
                    }
                }
            }
        }

        public static void PrintArrays(string[] nameArr, int[] marksArr)
        {
            Console.WriteLine("Name\tMarks");
            for (int index = 0; index < nameArr.Length; index++)
            {
                Console.WriteLine("{0}\t{1}", nameArr[index], marksArr[index]);
            }
        }
    }
}
