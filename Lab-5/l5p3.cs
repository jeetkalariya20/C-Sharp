﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5p3
{
    internal class l5p3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of Square : ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Length of Rectangle : ");
            double l2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth of Recangle : ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter radius of Circle : ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Square = " + Area(l));
            Console.WriteLine("Area of Rectangle = " + Area(l2, b2));
            Console.WriteLine("Area of Circle = " + Area(r));

            Console.ReadLine();
        }
        public static double Area(double l)
        {
            return Math.Round(l * l, 2);
        }
        public static double Area(double l, double b)
        {
            return Math.Round(l * b, 2);
        }
        public static double Area(int r)
        {
            return Math.Round(Math.PI * r * r, 2);
        }
    }
}
