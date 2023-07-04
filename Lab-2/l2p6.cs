using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            String a = "";
            String b = "";
            while (n > 0)
            {
                a = a + Convert.ToString(n % 2);
                n = n / 2;

            }
            for (int i = a.Length - 1; i > -1; i--)
            {
                b = b + Convert.ToString(a[i]);
            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
