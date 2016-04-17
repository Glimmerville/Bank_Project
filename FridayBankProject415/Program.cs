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
            Client BankClient = new Client();//BankClient = client's info
            BankClient.ClientName = Client.FullName("Stan", "Lee");
            BankClient.AcctNumber = Account.generateAcctNum();// Generate random account # 
            Account AccountClient = new Account(0, 0, 0, 0, true);//AccountClient = client's money & validation
            using (StreamWriter outputFile = new StreamWriter("CheckingSummary.txt"))
            {
                outputFile.WriteLine("FIRST WCCI BANK");
                outputFile.WriteLine("~~~~~~~~~~~~~~~");
                outputFile.WriteLine("Client: " + BankClient.ClientName);
                outputFile.WriteLine("Account Number: " + BankClient.AcctNumber);
                outputFile.WriteLine("\r\n");
            }
            using (StreamWriter outputFileSv = new StreamWriter("SavingsSummary.txt"))
            {
                outputFileSv.WriteLine("FIRST WCCI BANK");
                outputFileSv.WriteLine("~~~~~~~~~~~~~~~");
                outputFileSv.WriteLine("Client: " + BankClient.ClientName);
                outputFileSv.WriteLine("Account Number: " + BankClient.AcctNumber);
                outputFileSv.WriteLine("\r\n");
            }
            using (StreamWriter outputFileRv = new StreamWriter("ReserveSummary.txt"))
            {
                outputFileRv.WriteLine("FIRST WCCI BANK");
                outputFileRv.WriteLine("~~~~~~~~~~~~~~~");
                outputFileRv.WriteLine("Client: " + BankClient.ClientName);
                outputFileRv.WriteLine("Account Number: " + BankClient.AcctNumber);
                outputFileRv.WriteLine("\r\n");
            }
            BankMenu();

            int menuChoice = 0;
            while (menuChoice != 5)
            {
                int input;
                bool success = int.TryParse(Console.ReadLine(), out input);//This fixed stuff!
                switch (input)
                {
                    case 1: //view client info
                        Console.Clear();
                        HeaderText();
                        Console.WriteLine("\n\nClient name: " + BankClient.ClientName);
                        Console.WriteLine("Account Number: " + BankClient.AcctNumber);
                        Console.WriteLine("Savings Balance:"); //+ BankClient.SavingsBal);
                        Console.WriteLine("Checking Balance:"); //+ BankClient.CheckingBal);
                        Console.WriteLine("Reserve Balance:"); //+ BankClient.ReserveBal);
                        Console.ReadKey();
                        Console.Clear();
                        BankMenu();
                        break;
                    case 2: //view acct balance
                        Console.Clear();
                        HeaderText();
                        AccountsMenu();
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
        public static void AccountsMenu()
        {
            Console.WriteLine("\n\nPick an Option From the Following Menu:\n");
            Console.WriteLine("1.  View Checking Account Balance");
            Console.WriteLine("2.  View Savings Account Balance");
            Console.WriteLine("3.  View Reserve Account Balance");
            Console.WriteLine("4.  Exit");
            int menuChoice = 0;
            while (menuChoice != 4)
            {
                int input;
                bool success = int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1://checking
                        Console.Clear();
                        HeaderText();
                        Console.WriteLine("You are viewing your checking account balance");
                        Console.ReadKey();
                        Console.Clear();
                        HeaderText();
                        AccountsMenu();
                        break;
                    case 2://saving
                        Console.Clear();
                        HeaderText();
                        Console.WriteLine("You are viewing your savings account balance");
                        Console.ReadKey();
                        Console.Clear();
                        HeaderText();
                        AccountsMenu();
                        break;
                    case 3://reserve
                        Console.Clear();
                        HeaderText();
                        Console.WriteLine("You are viewing your Reserve account balance");
                        Console.ReadKey();
                        Console.Clear();
                        HeaderText();
                        AccountsMenu();
                        break;
                    case 4://exit
                        Console.Clear();
                        BankMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        AccountsMenu();
                        break;
                }
            }
        }
    }
}
