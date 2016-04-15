using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FridayBankProject415
{
    class Accounts
    {
        //field
        private double clientBalance;
        //I cannot figure out another field to put here
        //Create a random "is account valid" field
        //for if account balance is not negative??? or account start date?
        //Lauren said sure do whatever.
        private bool validateAccount;

        //properties
        public double ClientBalance { get { return this.clientBalance; } set { this.clientBalance = value; } }


        //methods
        public static string generateAcctNum()//METHOD
        {
        StringBuilder sbnumber = new StringBuilder();
        Random acctDigit = new Random();
            for (int i = 0; i< 10; i++)
            {
                sbnumber.Append(acctDigit.Next(0, 10));
            }
            return sbnumber.ToString();
        }
        public void Deposit()//METHOD
        {
            Console.WriteLine("\n\nHow much would you like to deposit?");
            double depositAmt = double.Parse(Console.ReadLine());
            this.ClientBalance = this.ClientBalance + depositAmt;
            Console.WriteLine("Your current balance is: $" + ClientBalance);
            using (StreamWriter outputFile = File.AppendText("AccountSummary.txt"))
            {
                outputFile.Write(DateTime.Now);
                outputFile.Write(" $" + depositAmt + " \t+ \tCurrent Balance: \t$" + this.ClientBalance);
                outputFile.Write("\r\n");
            }
        }
        public void Withdraw()//METHOD
        {
            Console.WriteLine("\n\nHow much would you like to withdraw?");
            Double withdrawAmt = double.Parse(Console.ReadLine());
            if (withdrawAmt > this.ClientBalance)
            {
                Console.WriteLine("Your account does not hold that much money. Invalid amount.");
            }
            else
            {
                this.ClientBalance = this.ClientBalance - withdrawAmt;
                Console.WriteLine("Your current balance is: $" + ClientBalance);
                using (StreamWriter outputFile = File.AppendText("AccountSummary.txt"))
                {
                    outputFile.Write(DateTime.Now);
                    outputFile.Write(" $" + withdrawAmt + " \t- \tCurrent Balance: \t$" + this.ClientBalance);
                    outputFile.Write("\r\n");
                }
            }
        }

        //Constructor - sets up client balance. 
        public Accounts(int cBalance)
        {
            this.ClientBalance = cBalance;
        }
    }
}
