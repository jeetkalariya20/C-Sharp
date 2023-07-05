using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3p5
{
    internal class l3p5
    {
        static void Main(string[] args)
        {
            Salary s = new Salary();
            s.CalculateSalary();
            Console.ReadLine();
        }
    }
    class Salary
    {
        double TA;
        double DA;
        double HRA;

        public Salary()
        {
            Console.WriteLine("Enter TA : ");
            TA = Convert.ToDouble(Console.ReadLine());
            DA = 10000;
            HRA = 15000;
        }

        public void CalculateSalary()
        {
            Console.WriteLine("Salary is : " + (TA + DA + HRA));
        }
    }
