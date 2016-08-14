using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            string strA = Console.ReadLine();
            string strB = Console.ReadLine();
            string strC = Console.ReadLine();

            double a = Convert.ToDouble(strA);
            double b = Convert.ToDouble(strB);
            double c = Convert.ToDouble(strC);

            Console.WriteLine(CalculateArea(a, b, c));

        }

        public static double CalculateArea(double a, double b, double c)
        {
            //Math.Max(a, Math.Max(b, c)) > s;

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s*(s - a)*(s - b)*(s - c));

            return area;
        }
    }
}