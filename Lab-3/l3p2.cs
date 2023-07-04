using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff
{
    internal class l3p2
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter n : ");
            n=Convert.ToInt32(Console.ReadLine());  
            Staff[] s= new Staff[n];
            for (i = 0; i < n; i++)
            {
                s[i]=new Staff();
                s[i].GetStaffDetails();
                s[i].DisplayStaffDetails();
            }
            Console.ReadLine();
        }
    }

    class Staff
    {
        string Name;
        string Department;
        string Designation;
        int Experience;
        int Salary;

        public void GetStaffDetails()
        {
            Console.WriteLine("Enter Name : ");
            Name= Console.ReadLine();

            Console.WriteLine("Enter Department : ");
            Department = Console.ReadLine();

            Console.WriteLine("Enter Designation : ");
            Designation = Console.ReadLine();

            Console.WriteLine("Enter Experience : ");
            Experience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Salary : ");
            Salary = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayStaffDetails()
        {
            if (Designation == "HOD")
            {
                Console.WriteLine("Name is : " + Name + " Salary is : " + Salary);
            }
            
        }
       
    }
}
