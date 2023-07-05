using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1p7
{
    internal class l1p7
    {
        static void Main(string[] args)
        {
            int p, r, n;
            double interest;

            Console.WriteLine("Enter P : ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter R : ");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter N : ");
            n = Convert.ToInt32(Console.ReadLine());

            interest = (p * r * n) / 100;

            Console.WriteLine("Simple interest is " + interest);

            Console.ReadLine();
        }
    }
}
