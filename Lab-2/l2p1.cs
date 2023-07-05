using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2p1
{
    internal class l2p1
    {
        static void Main(string[] args)
        {
            int height, weight;
            double kg, meter;

            Console.WriteLine("Enter height in inch");
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter weight in pound");
            weight = Convert.ToInt32(Console.ReadLine());

            meter = height * 0.0254;
            kg = weight * 0.453592;

            Console.WriteLine("BMI is : " + (kg / (meter * meter)));

            Console.ReadLine();
        }
    }
}
