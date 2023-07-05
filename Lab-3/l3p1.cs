using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3p1
{
    internal class l3p1
    {
        static void Main(string[] args)
        {
            Candidate c1 = new Candidate();
            c1.GetCandidateDetails();
            c1.DisplayCandidateDetails();

            Console.ReadLine();
        }
    }
    class Candidate
    {
        int ID;
        String Name;
        int Age;
        int Weight;
        int Height;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter ID : ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Age : ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Weight : ");
            Weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height : ");
            Height = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Weight : " + Weight);
            Console.WriteLine("Height : " + Height);
        }
    }
}