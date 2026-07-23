using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTASK3
{
    internal class Program
    {
        public class A
        {
            internal int i = 10;
        }
        public class B : A
        {
           protected internal int j = 20;
        }
        class PrintA
        {
            public PrintA(ref int r)
            {
                r = 60;
            }internal int printA;
        }
        class PrintB
        {
            public PrintB(out string o)
            {
                o = "TRY HARDER !";
            }
            protected internal int printB = 5;
        }
        public class Alpha
        {
            public static String s = "This is a string ";
            public Alpha()
            {
                s += "alpha ";
            }
        }
        class SubAlpha :Alpha
        {
            public SubAlpha()
            {
                s += "sub ";
            }
        }
        public class SubSubAlha: Alpha
        {
            public SubSubAlha()
            {
                s += "subsub ";
            }
            public static void printI(A a1)
            {
                Console.WriteLine(a1.i);
            }
            public static void printJ(B b1)
            {
                Console.WriteLine(b1.j);
                
            }

        }
        static void Main(string[] args)
        {
            A a = new A();
            a.i = 21;
            B b = new B();
            b.j = 25;

            SubSubAlha.printI(a);
            SubSubAlha.printI(b);
            SubSubAlha. printJ(b);
            
            

            Console.WriteLine(Alpha.s);
            Console.WriteLine("FIND THE OUTPUT");
             Alpha.s= null;

            //Console.WriteLine(Alpha.s);

            new SubAlpha();
            Console.WriteLine(Alpha.s);
            PrintA pa = new PrintA(ref a.i); //60
            PrintB pb = new PrintB(out Alpha.s);//try harder
            Console.WriteLine("Out output = "+ Alpha.s);
            Console.WriteLine("printA = "+pa.printA);
            Console.WriteLine("Ref output = "+a.i);
            Console.WriteLine("printB = "+pb.printB);


            Console.ReadKey();




        }
    }
}
