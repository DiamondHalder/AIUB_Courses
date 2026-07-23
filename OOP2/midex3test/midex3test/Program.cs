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
            }
            internal int printA;
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
            public static string s = "This is a string ";

            public Alpha()
            {
                s += "alpha ";
            }

            public static string S
            {
                get { return s; }
                set { s = value; }
            }
        }
        class SubAlpha : Alpha
        {
            public SubAlpha()
            {
                s += "sub ";
            }
        }
        public class SubSubAlpha : Alpha
        {
            public SubSubAlpha()
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

            SubSubAlpha.printI(a);
            SubSubAlpha.printI(b);
            SubSubAlpha.printJ(b);

            Console.WriteLine(Alpha.S);
            Console.WriteLine("FIND THE OUTPUT");
            Alpha.S = null;
            new SubSubAlpha();
            Console.WriteLine(Alpha.S);
            PrintA pa = new PrintA(ref a.i);
             PrintB pb = new PrintB(out Alpha.s);
            
            Console.WriteLine("Out output = " + Alpha.S);
            Console.WriteLine("printA = " + pa.printA);
            Console.WriteLine("Ref output = " + a.i);
             Console.WriteLine("printB = " + pb.printB);
            Console.ReadKey();
        }
    }
}