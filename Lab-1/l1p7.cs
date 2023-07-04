using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, r, n;
            double interest;

            Console.WriteLine("Enter P : ");
            p=Convert.ToInt32(Console.ReadLine());

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
