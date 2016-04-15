using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FridayBankProject415
{
    class Accounts: Clients
    {
        //field
        private int clientBalance;
        //private string authNumber; //I wish I could check vs the client number, but it is randomly generated.
        //private string - maybe transaction date? or location?
        //deposit into savings
        //deposit into checking?
        //that would be fun, to have two

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
            Console.WriteLine("\n\nHow much would you like to deposit?");
            double depositAmt = double.Parse(Console.ReadLine());
            //BankClient.ClientBalance = BankClient.ClientBalance + depositAmt;
            //Console.WriteLine("Your current balance is: " + (ClientBalance));
        }
        public static void Withdraw()
        {
            Console.WriteLine("\n\nHow much would you like to withdraw?");
            Double withdrawAmt = double.Parse(Console.ReadLine());
        }
        //Constructor - sets up client balance. Sort of. Does not work yet
        public void UpdateClientBal(int cBalance)
        {
          this.clientBalance = cBalance;
        }

    }
}
