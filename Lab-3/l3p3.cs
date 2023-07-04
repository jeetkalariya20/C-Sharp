using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class l3p3
    {
        static void Main(string[] args)
        {
            Bank_Account b = new Bank_Account();
            b.GetBankDetails();
            b.DisplayBankDetails();
            Console.ReadLine();
        }
    }
    class Bank_Account
    {
        int Account_No;
        string Email;
        string User_Name;
        string Account_Type;
        double Account_Balance;

        public void GetBankDetails()
        {
            Console.WriteLine("Enter Account_No : ");
            Account_No=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Email : ");
            Email = Console.ReadLine();

            Console.WriteLine("Enter User_Name : ");
            User_Name = Console.ReadLine();

            Console.WriteLine("Enter Account_Type : ");
            Account_Type =Console.ReadLine();

            Console.WriteLine("Enter Account_Balance : ");
            Account_Balance = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayBankDetails()
        {
            Console.WriteLine("Account_No : " + Account_No);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("User_Name : " + User_Name);
            Console.WriteLine("Account_Type : " + Account_Type);
            Console.WriteLine("Account_Balance : " + Account_Balance);
        }
    }
}
