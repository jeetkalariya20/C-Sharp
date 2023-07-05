using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    internal class l3p6
    {
        static void Main(string[] args)
        {
            Distance d = new Distance();
            Console.WriteLine("Total Distance : " + d.calculateDistance());
            Console.ReadLine();
        }
    }
    class Distance
    {
        public double D1;
        public double D2;
        public double D3;

        public Distance()
        {
            D1 = 50;
            D2 = 150;
        }

        public double calculateDistance()
        {
            D3 = D2 + D1;
            return D3;
        }
    }
}
