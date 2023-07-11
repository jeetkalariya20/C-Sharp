using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4p8
{
    internal class l4p8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Character : ");
            Char c = Convert.ToChar(Console.ReadLine());

            Char newChar = c.ToString().ToUpper().ToCharArray()[0];
            Console.WriteLine("Changed Character : " + newChar);
            Console.ReadLine();
        }
    }
}
