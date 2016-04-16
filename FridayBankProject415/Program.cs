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
        //set up some methods I will use a lot
        static void HeaderText()
        {
            Console.WriteLine("        **************************");
            Console.WriteLine("        *    FIRST WCCI BANK     *");
            Console.WriteLine("        **************************");
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
        //Main
        static void Main(string[] args)
        {
            //Hard Coded Client per instructions
            Clients BankClient = new Clients();//BankClient = client's info
            BankClient.ClientName = "Stan Lee";
            BankClient.AcctNumber = Accounts.generateAcctNum();// Generate random account # 
            Accounts AccountClient = new Accounts(0, true);//AccountClient = client's money & validation
            using (StreamWriter outputFile = new StreamWriter("AccountSummary.txt"))
            {
                outputFile.WriteLine("FIRST WCCI BANK");
                outputFile.WriteLine("~~~~~~~~~~~~~~~");
                outputFile.WriteLine("Client: " + BankClient.ClientName);
                outputFile.WriteLine("Account Number: " + BankClient.AcctNumber);
                outputFile.WriteLine("\r\n");
            }

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
                        Console.ReadKey();
                        Console.Clear();
                        BankMenu();
                        break;
                    case 2: //view acct balance
                        Console.Clear();
                        HeaderText();
                        Console.WriteLine("\n\nYour current balance is: $" + AccountClient.ClientBalance);
                        Console.ReadKey();
                        Console.Clear();
                        BankMenu();
                        break;
                    case 3: //deposit funds
                        Console.Clear();
                        HeaderText();
                        AccountClient.Deposit();
                        Console.ReadKey();
                        Console.Clear();
                        BankMenu();
                        break;
                    case 4://withdraw funds
                        Console.Clear();
                        HeaderText();
                        AccountClient.Withdraw();
                        Console.ReadKey();
                        Console.Clear();
                        BankMenu();
                        break;
                    case 5://exit
                        Console.Clear();
                        HeaderText();
                        Console.WriteLine("\nThank you for using First WCCI Bank.");
                        Environment.Exit(0);
                        break;
                    default://I love adding sleep and making it pause.
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
