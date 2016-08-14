using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            string strSalary = Console.ReadLine();
            double resultDbl = Convert.ToDouble(CalculateIncome(strSalary));
            Console.WriteLine("${0:#,##0.00}", resultDbl);

        }

        public static string CalculateIncome(string salaryStr)
        {
            double salaryDbl = Convert.ToDouble(salaryStr);
            double resultDbl = salaryDbl * 1.13;
            string result = Convert.ToString(resultDbl);
            return result;
        }
    }
}
