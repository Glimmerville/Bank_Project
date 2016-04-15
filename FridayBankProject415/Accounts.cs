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
        private int clientBalance;
        //private string - maybe transaction date? or location?

        //properties
        public int ClientBalance { get { return this.clientBalance; } set { this.clientBalance = value; } }
        //need one more

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
        public static void Deposit()//METHOD
        {
            Console.WriteLine("How much would you like to deposit?");
            int depositAmt = int.Parse(Console.ReadLine());
          //  BankClient.ClientBalance = BankClient.ClientBalance + depositAmt;
            //Console.WriteLine("Your current balance is: " + (ClientBalance));
        }
    }
}
