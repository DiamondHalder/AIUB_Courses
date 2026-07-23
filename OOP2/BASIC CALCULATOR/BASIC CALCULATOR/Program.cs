using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC_CALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char sign;
            Console.Write("Enter the operator - ");
            sign = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the 1st Number - ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number - ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (sign)
            { 
                case '+':
                    Console.WriteLine("num1+num2 = "+num1+num2);
                    break;
                case '-':
                    Console.WriteLine("num1-num2 = " + (num1-num2));
                    break;  
                case '*':
                    Console.WriteLine("num1*num2 = "+num1*num2);
                    break;
                case '/':
                    Console.WriteLine("num1/num2 = "+num1/num2);
                    break;
                default:
                    Console.WriteLine(" error ");
                    break;


            }
            Console.ReadKey();

        }
    }
}
