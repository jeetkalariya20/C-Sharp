using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenhit_Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, c;
            Console.WriteLine("Enter f: ");
            f = Convert.ToInt32(Console.ReadLine());
            c = ((f - 32) * 5) / 9;
            Console.WriteLine(c + " ");

            Console.WriteLine("Enter c: ");
            c = Convert.ToInt32(Console.ReadLine());
            f = (c * 9) / 5 + 32;
            Console.WriteLine(f + " ");

            Console.ReadLine();
        }
    }
}
