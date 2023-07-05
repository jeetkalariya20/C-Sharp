using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2p5
{
    internal class l2p5
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, n;
            Console.Write("Enter the number of elements: ");
            n = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            Console.ReadLine();
        }
    }
}
