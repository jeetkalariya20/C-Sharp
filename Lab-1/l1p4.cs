using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1p4
{
    internal class l1p4
    {
        static void Main(string[] args)
        {
            int length, width, area;
            Console.WriteLine("Enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width");
            width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            Console.WriteLine("Area is : " + area);
            Console.ReadLine();
        }
    }
}
