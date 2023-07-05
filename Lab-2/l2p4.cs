using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2p4
{
    internal class l2p4
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 400 == 0) || year % 100 != 0)
            {
                Console.WriteLine(year + " is leap year");
            }
            else
            {
                Console.WriteLine(year + " not leap year");
            }

            Console.ReadLine();
        }
    }
}
