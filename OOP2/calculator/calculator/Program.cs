using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {

        class calculator
        {
            
            
            
            public void add(int num1,int num2)
            {
               int num = num1 + num2;
                Console.WriteLine($"{num1}+{num2}={num1+num2}");

            
            }public void sub(int num1,int num2)
            {
               int num = num1 - num2;
                Console.WriteLine($"{num1}-{num2}={num}");

            }
            public void mul(int num1,int num2)
            {
               int num = num1 * num2;
                Console.WriteLine($"{num1}*{num2}={num}");

            }
            public void div(int num1,int num2)
            {
               int num = num1 / num2;
                Console.WriteLine($"{num1}/{num2}={num}");

            }

        }
        static void Main(string[] args)
        {

            int num1, num2;

            Console.Write("Enter num1 - ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter num2 - ");
                num2 = Convert.ToInt32(Console.ReadLine());
            
            
            calculator obj1 = new calculator();
            
            obj1.add(num1,num2);
            obj1.sub(num1,num2);
            obj1.mul(num1,num2);
            obj1.div(num1,num2);
            Console.ReadKey();
        }


    }

}
