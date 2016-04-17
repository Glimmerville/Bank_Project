using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FridayBankProject415
{
    class Account
    {
        //field
        private double clientBalance;
        private bool validateAccount;
        private string output; //Output = current stream
        private double SavingsBalance { get; set; } = 0;
        private double CheckingBalance { get; set; } = 0;
        private double ReserveBalance { get; set; } = 0;
        public string serviceName = "Bank";

        //properties
        public double ClientBalance { get { return this.clientBalance; } set { this.clientBalance = value; } }
        public bool ValidateAccount { get { return this.validateAccount; } set { this.validateAccount = value; } }
        public virtual string Output { get { return this.output; } set { this.output = value; } }
        //methods
        public static string generateAcctNum()//METHOD
        {
            StringBuilder sbnumber = new StringBuilder();
            Random acctDigit = new Random();
            for (int i = 0; i < 10; i++)
            {
                sbnumber.Append(acctDigit.Next(0, 10));
            }
            return sbnumber.ToString();
        }
        public void Deposit()//METHOD
        {
            Console.WriteLine("\n\nHow much would you like to deposit into {0}?", serviceName);
            double depositAmt = double.Parse(Console.ReadLine());
            this.ClientBalance = this.ClientBalance + depositAmt;
            Console.WriteLine("Your current {0} balance is: $", serviceName + ClientBalance);
            try
            {
                using (StreamWriter outputFile = File.AppendText(Output))
                {
                    outputFile.Write("Transaction: " + DateTime.Now);
                    outputFile.Write(" + $" + depositAmt + "\tUpdated Balance: $" + this.ClientBalance);
                    outputFile.Write("\r\n");
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can't find file {0}", Output); //Output = current stream
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can't open the file {0}", Output); //Output = current stream
            }
        }
        public void Withdraw()//METHOD
        {
            Console.WriteLine("\n\nHow much would you like to withdraw from {0}?", serviceName);
            Double withdrawAmt = double.Parse(Console.ReadLine());
            if (withdrawAmt > this.ClientBalance)
            {
                Console.WriteLine("Your {0} account does not hold that much money. Invalid amount.", serviceName);
            }
            else
            {
                this.ClientBalance = this.ClientBalance - withdrawAmt;
                Console.WriteLine("Your current {0} balance is: $", serviceName + ClientBalance);
                try
                {
                    using (StreamWriter outputFile = File.AppendText(Output)) //Output = current stream
                    {
                        outputFile.Write("Transaction: " + DateTime.Now);
                        outputFile.Write(" - $" + withdrawAmt + "\tUpdated Balance: $" + this.ClientBalance);
                        outputFile.Write("\r\n");
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.Error.WriteLine("Can't find file {0}", Output); //Output = current stream
                }
                catch (DirectoryNotFoundException)
                {
                    Console.Error.WriteLine("Invalid directory in the file path.");
                }
                catch (IOException)
                {
                    Console.Error.WriteLine("Can't open the file {0}", Output);//Output = current stream
                }
            }
        }

        //constructor - sets up client balance and validates client 
        public Account()
        {
            // default constructor
        }
        public Account(double cBalance, double sBalance, double rBalance, double chBalance, bool cValidate)
        {
            this.ClientBalance = cBalance;
            this.CheckingBalance = chBalance;
            this.SavingsBalance = sBalance;
            this.ReserveBalance = rBalance;
            this.ValidateAccount = cValidate;

        }

    }
}
