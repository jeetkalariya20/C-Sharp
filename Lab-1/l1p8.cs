using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1p8
{
    internal class l1p8
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter n1 : ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n2 : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.For add press + \n 2.For sub press - \n 3.For mul press * \n 4.For divi press / ");
            String ch = Console.ReadLine();

            if (ch == "+")
            {
                Console.WriteLine("Addition is : " + (n1 + n2));
            }
            else if (ch == "-")
            {
                Console.WriteLine("Sub is : " + (n1 - n2));
            }
            else if (ch == "*")
            {
                Console.WriteLine("Multi is : " + (n1 * n2));
            }
            else if (ch == "/")
            {
                Console.WriteLine("Divi is : " + (n1 / n2));
            }
            else
            {
                Console.WriteLine("Please enter correct sign");
            }

            Console.ReadLine();
        }
    }
}
