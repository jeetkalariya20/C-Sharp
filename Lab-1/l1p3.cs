using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name, country;

            Console.WriteLine("Enter Name : ");
            name= Console.ReadLine();

            Console.WriteLine("Enter Country : ");
            country= Console.ReadLine();

            Console.WriteLine("Hello " + name + " from country " + country);

            Console.ReadLine();
        }
    }
}
