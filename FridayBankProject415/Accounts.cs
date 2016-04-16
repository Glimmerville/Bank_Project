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
        private bool validateAccount;
        private string Output { get; } = @"AccountSummary.txt";

        //properties
        public double ClientBalance { get { return this.clientBalance; } set { this.clientBalance = value; } }
        public bool ValidateAccount { get { return this.validateAccount; } set { this.validateAccount = value; } }
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
            try
            { 
                using (StreamWriter outputFile = File.AppendText(Output))
                {
                    outputFile.Write("Transaction: "+DateTime.Now);
                    outputFile.Write(" + $" + depositAmt + "\tUpdated Balance: $" + this.ClientBalance);
                    outputFile.Write("\r\n");
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can't find file {0}", Output);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch(IOException)
            {
                Console.Error.WriteLine("Can't open the file {0}", Output);
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
                try
                {
                    using (StreamWriter outputFile = File.AppendText(Output))
                    {
                        outputFile.Write("Transaction: " +DateTime.Now);
                        outputFile.Write(" - $" + withdrawAmt + "\tUpdated Balance: $" + this.ClientBalance);
                        outputFile.Write("\r\n");
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.Error.WriteLine("Can't find file {0}", Output);
                }
                catch (DirectoryNotFoundException)
                {
                    Console.Error.WriteLine("Invalid directory in the file path.");
                }
                catch (IOException)
                {
                    Console.Error.WriteLine("Can't open the file {0}", Output);
                }
            }
        }

        //constructor - sets up client balance and validates client 
        public Accounts()
        {
            // default constructor
        }
        public Accounts(int cBalance, bool cValidate)
        {
            this.ClientBalance = cBalance;
            this.ValidateAccount = cValidate;
        }
    
    }
}
