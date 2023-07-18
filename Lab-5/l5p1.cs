using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5p1
{
    internal class l5p1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st Integer number : ");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd Integer number : ");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 1st Double number : ");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 2nd Double number : ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Addition of Integers = " + Addition(a1, a2));
            Console.WriteLine("Addition of Doubles = " + Addition(b1, b2));

            Console.ReadLine();
        }
        public static int Addition(int n1, int n2)
        {
            return n1 + n2;
        }
        public static double Addition(double a, double b)
        {
            return a + b;
        }

    }
}
