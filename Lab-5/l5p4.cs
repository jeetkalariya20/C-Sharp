using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5p4
{
    internal class l5p4
    {
        static void Main(string[] args)
        {
            RBI rbi = new RBI();
            HDFC hdfc = new HDFC();
            SBI sbi = new SBI();
            ICICI icici = new ICICI();

            rbi.calculateInterest();
            hdfc.calculateInterest();
            sbi.calculateInterest();
            icici.calculateInterest();
            Console.ReadLine();
        }
    }
    class RBI
    {
        public virtual void calculateInterest()
        {
            Console.WriteLine("Interest of SBI");
        }
    }
    class HDFC : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Interest of RBI");
        }
    }
    class SBI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Interest of SBI");
        }
    }
    class ICICI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Interest of ICICI");
        }
    }
}
