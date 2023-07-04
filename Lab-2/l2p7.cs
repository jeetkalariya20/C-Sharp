using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nPr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, n,r;
            Console.Write("Enter n : ");
            n=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter r : ");
            r = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            int temp,fact1=1;
            temp = n - r;
            for(i = 1; i <= temp; i++)
            {
                fact1 = fact1 * i;
            }

            Console.Write("nPr is : " + (fact / fact1));
            Console.ReadLine();
        }
    }
}
