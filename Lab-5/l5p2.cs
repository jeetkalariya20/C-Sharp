using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5p2
{
    internal class l5p2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of Square : ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Length of Rectangle : ");
            double l1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Breadth of Recangle : ");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of Square = " + Area(l));
            Console.WriteLine("Area of Rectangle = " + Area(l1, b1));

            Console.ReadLine();
        }
        public static double Area(double l)
        {
            return l * l;
        }
        public static double Area(double l, double b)
        {
            return l * b;
        }
    }
}
