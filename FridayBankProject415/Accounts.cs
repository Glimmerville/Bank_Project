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
        //If I cannot figure out a field to put here
        //maybe a field connected to writing out to streamwriter
        //So save each transaction in a string
        //THEN push them all to streamwriter

        //I want to associate the client balance with the client somehow other than this
        //Lauren said these items don't need to be associated at all
        //So just make it print the line it needs to print.

        //deposit into savings vs checking? Transfers?
        //that would be fun, to have two. Maybe I will do that later.

        //properties
        public double ClientBalance { get { return this.clientBalance; } set { this.clientBalance = value; } }
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
        public void Deposit()//METHOD
        {
            Console.WriteLine("\n\nHow much would you like to deposit?");
            double depositAmt = double.Parse(Console.ReadLine());
            this.ClientBalance = this.ClientBalance + depositAmt;
            Console.WriteLine("Your current balance is: " + ClientBalance);
            //"Take the input and save it, change balance, also print to document (streamwriter)"
            
        }
        public void Withdraw()
        {
            Console.WriteLine("\n\nHow much would you like to withdraw?");
            Double withdrawAmt = double.Parse(Console.ReadLine());
            if (withdrawAmt > this.ClientBalance)
            {
                Console.WriteLine("Your account does not hold that much money. Invalid amount.");
            }
        }

        //Constructor - sets up client balance. 
        //thinking in objects, we need an "account holder to hold this balance" I think.
        public Accounts(int cBalance)
        {
            this.ClientBalance = cBalance;
        }
    }
}
