using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class l3p7
    {
        static void Main(string[] args)
        {
            Area a = new Area(60,60);
            a.DisplayArea();
            Console.ReadLine();
        }
    }
    class Area
    {
        double length;
        double breath;

        public Area(double length, double breath)
        {
            this.length = length;
            this.breath = breath;
        }

        public void DisplayArea()
        {
            Console.WriteLine(" Area : " + (length * breath));
        }
    }
}
