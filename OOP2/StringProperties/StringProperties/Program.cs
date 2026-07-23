using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringMan
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a string";

            int a = str.Length;          // a = 16 (length of "This is a string")
            string ss = str.ToUpper();    // ss = "THIS IS A STRING" (converts to uppercase)
            string sl = str.ToLower();    // sl = "this is a string" (converts to lowercase)
            string se = str.Substring(0, 6);  // se = "This i" (extracts substring from index 0 to 6)
            string sg = str.Replace('s', '5'); // sg = "Thi5 i5 a 5tring" (replaces 's' with '5')
            string sin = str.Insert(0, "New"); // sin = "NewThis is a string" (inserts "New" at index 0)

            string st = str.Trim();       // st = "This is a string" (no leading or trailing spaces to trim)

            string str2 = "this-is-a-string";

            string[] s = str2.Split('-');  // s = ["this", "is", "a", "string"] (splits by '-')

            foreach (string sss in s)
            {
                Console.WriteLine(sss);   // Outputs:
                // this
                // is
                // a
                // string
            }

            bool scon = str.Contains("string");   // scon = true (because "string" is found in str)

            Console.WriteLine(str.Equals(str2));  // Output: false (since "This is a string" != "this-is-a-string")

            Console.WriteLine(scon);              // Output: true (as 'str' contains "string")

            Console.ReadKey();
        }
    }
}
