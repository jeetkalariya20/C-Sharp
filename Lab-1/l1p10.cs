using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            Console.ReadLine();
        }
    }
}
