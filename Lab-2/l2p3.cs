using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2p3
{
    internal class l2p3
    {
        static void Main(string[] args)
        {
            int n, i, flag = 0;
            Console.WriteLine("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine(n + " is Not Prime");
            }
            else
            {
                Console.WriteLine(n + " is Prime");
            }

            Console.ReadLine();
        }
    }
}
