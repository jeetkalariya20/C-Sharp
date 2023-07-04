using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject_Per
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, s4, s5;
            double per;
            Console.WriteLine("Enter S1: ");
            s1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter S2: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter S3: ");
            s3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter S4: ");
            s4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter S5: ");
            s5 = Convert.ToInt32(Console.ReadLine());

            per=(s1+s2+s3+s4+s5)/5;

            if (per >= 60)
            {
                Console.WriteLine("First Division");
            }
            if (per >= 50 && per<=59)
            {
                Console.WriteLine("Second Division");
            }
            if (per >= 40 && per <=49)
            {
                Console.WriteLine("Third Division");
            }
            if (per < 40)
            {
                Console.WriteLine("Fail...");
            }
            
            Console.ReadLine(); 

        }
    }
}
