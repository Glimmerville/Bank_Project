using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayBankProject415
{
    class Checking:Account
    {
        //field 
        public new string Output = @"CheckingSummary.txt";
        public new string serviceName = "Checking";
        private double checkingBalance;

        public new double ClientBalance { get { return this.checkingBalance; } set { this.checkingBalance = value; } }
        public static void CheckingMenu()
        {
            Console.WriteLine("\n\nPick an Option From the Following Menu:\n");
            Console.WriteLine("1.  View Checking Account Balance");
            Console.WriteLine("2.  Deposit Funds");
            Console.WriteLine("3.  Withdraw Funds");
            Console.WriteLine("4.  Exit");
        }

    }
}
