using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4p7
{
    internal class l4p7
    {
        static void Main(string[] args)
        {
            String s = "Jeet Patel";

            Console.WriteLine("Length Of Stinrg Is : " + s.Length);
            Console.WriteLine("Substring : " + s.Substring(1));
            Console.WriteLine("Contains: " + s.Contains("Yash"));
            Console.WriteLine("Replaced : " + s.Replace("Yash", "yash"));
            Console.WriteLine("Index of 'Yash': " + s.IndexOf("Yash"));
            Console.WriteLine("Upper Case Conversion: " + s.ToUpper());
            Console.WriteLine("Lower Case Conversion: " + s.ToLower());
            Console.WriteLine("Formate String : " + string.Format("Hii ! I'm {0}", s));
            Console.ReadLine();
        }
    }
}
