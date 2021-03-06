﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            string x_1 = Console.ReadLine();
            string y_1 = Console.ReadLine();
            string x_2 = Console.ReadLine();
            string y_2 = Console.ReadLine();
            double resultDbl = CalculateDistance(Convert.ToDouble(x_1), Convert.ToDouble(y_1), Convert.ToDouble(x_2), Convert.ToDouble(y_2));
            Console.WriteLine(resultDbl);
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double Distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return Distance;
        }
    }
}
