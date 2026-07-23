using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace setget
{
    internal class Program
    {
        class identity
        {
            private string name;
            private string age;

            public void set(string name)
            {
                this.name = name;

            }
            public string get()
            {
                return name;
            }
            /*public void set1(string age)
            {
                this.age = age;

            }
            public string get1()
            {
                return age;
            }*/
            public string Age
            {
                set { age = value; }
                get { return age; }
                           
            }
            public void display()
            {
                Console.WriteLine($"The name of the person is : {name}");
                Console.WriteLine($"The age of the person is : {age}");

            }
        }



        static void Main(string[] args)
        {
                identity i = new identity();
                i.set  ("diamond");
                i.Age ="22";
                i.get();
                
               // i.get1();
                i.display();
            //Console.WriteLine(i.Age);




            Console.ReadKey();
        }
    }
}
