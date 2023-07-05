using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1p9
{
    internal class l1p9
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c : ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Max is : " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Max is : " + b);
            }
            else
            {
                Console.WriteLine("Max is : " + c);
            }

            Console.ReadLine();
        }
    }
}
