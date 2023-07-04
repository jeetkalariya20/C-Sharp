using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input2Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;

            Console.WriteLine("Enter n1 : ");
            n1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n2 : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("n1 is : " + n1 + " n2 is : " + n2);

            Console.ReadLine();
        }
    }
}
