using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace FridayBankProject415
{
    class Program
    {
        //set up some methods
        static void HeaderText()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("*    FIRST WCCI BANK     *");
            Console.WriteLine("**************************");
        }
        static void BankMenu()
        {
            HeaderText();
            Console.WriteLine("\n\nPick an Option From the Following Menu:\n");
            Console.WriteLine("1.  View Client Information");
            Console.WriteLine("2.  View Account Balance");
            Console.WriteLine("3.  Deposit Funds");
            Console.WriteLine("4.  Withdraw Funds");
            Console.WriteLine("5.  Exit");
        }
        static void Main(string[] args)
        {
            //Hard Coded Client per instructions
            Clients BankClient = new Clients();
            BankClient.ClientName = "Stan Lee";
            BankClient.AcctNumber = Accounts.generateAcctNum();
            Accounts AccountClient = new Accounts(0);

        BankMenu();
           
            int menuChoice = 0;
            while (menuChoice != 5)
            {
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //view client info
                        Console.Clear();
                        HeaderText();
                        Console.WriteLine("\n\nClient name: " + BankClient.ClientName);
                        Console.WriteLine("Account Number: " + BankClient.AcctNumber);
                        break;
                    case 2: //view acct balance
                        Console.Clear();
                        HeaderText();
                        Console.WriteLine("Your current balance is:");
                        break;
                    case 3: //deposit funds
                        Console.Clear();
                        HeaderText();
                        Accounts.Deposit();
                        //"Take the input and save it, change balance, also print to document (streamwriter)"
                        break;
                    case 4://withdraw funds
                        Console.Clear();
                        HeaderText();
                        Accounts.Withdraw();
                        //"Take the input and update the amount the client has, also print to document (streamwriter)");
                        break;
                    case 5://exit
                        Console.Clear();
                        HeaderText();
                        Console.WriteLine("\nThank you for using First WCCI Bank.");
                        //Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default://the only cool part.
                        Console.WriteLine("Invalid choice.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        BankMenu();
                        break;
                }
            }
        }
    }
}
