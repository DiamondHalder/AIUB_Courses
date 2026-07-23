using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bio
{
    internal class Program
    {

        class Bio
        {
            public string name;
            public int age;
            
            public   Bio(string name, int age)
            {
                this.name = name;
                this.age = age; 
                
               
            }
            public void userinput()
            {
                Console.Write("Enter your name - ");
                name = Console.ReadLine();
                Console.Write("Enter your age - ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            public void display()
            {
                Console.WriteLine($"The name of the person is - {name}");
                Console.WriteLine($"The name of the age is - {age}");
            }

        }
        static void Main(string[] args)
        {
            string n;
            int a;
            

            Bio obj1 = new Bio(n,a);
            Bio obj2 = new Bio(n,a);
            obj1.userinput();
            obj2.userinput();

            obj1.display();
            obj2.display(); 
           
           




            Console.ReadKey();
        }
        
        
    }
    
}
