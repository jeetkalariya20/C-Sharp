using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3p4
{
    internal class l3p4
    {
        static void Main(string[] args)
        {
            Student s = new Student(210101010, "XYZ", 5, 8, 7);
            s.DisplayStudentDetails();
            Console.ReadLine();
        }
    }
    class Student
    {
        int Enrollment_No;
        string Student_Name;
        int Semester;
        int SPI;
        int CPI;

        public Student(int Enrollment_No, string Student_No, int Semester, int SPI, int CPI)
        {
            this.Enrollment_No = Enrollment_No;
            this.Student_Name = Student_No;
            this.Semester = Semester;
            this.SPI = SPI;
            this.CPI = CPI;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Enrollment_No : " + Enrollment_No);
            Console.WriteLine("Student_Name : " + Student_Name);
            Console.WriteLine("Semester : " + Semester);
            Console.WriteLine("SPI : " + SPI);
            Console.WriteLine("CPI : " + CPI);
        }
    }
