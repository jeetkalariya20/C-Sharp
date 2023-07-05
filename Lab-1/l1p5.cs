using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class l1p5
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("1.Square \n 2.Rectangle \n 3.Circle");
                double ch;
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        int a;
                        Console.WriteLine("Enter a : ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Area of square is " + (a * a));
                        break;

                    case 2:
                        int l, b;
                        Console.WriteLine("Enter l : ");
                        l = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter b : ");
                        b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Area of rectangle is : " + (l * b));
                        break;

                    case 3:
                        int r;
                        Console.WriteLine("Enter r : ");
                        r = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Area of circle is : " + (3.14 * r * r));
                        break;
                }

                Console.ReadLine();
            }
        
    }
}
