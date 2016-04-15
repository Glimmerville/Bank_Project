using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FridayBankProject415
{
    class Clients
    {
        //field
        private string clientName;
        private string acctNumber;

        //properties
        public string ClientName { get { return this.clientName; } set { this.clientName = value; } }
        public string AcctNumber { get { return this.acctNumber; } set { this.acctNumber = value; } }
        //I should never need to set the client number! they only get one number.
        //note: Lauren said it's ok to use random to generate a number and assign it
        //even though this means it will change every time you open the program.
        //should I try-parse to make sure they put in numbers on the balance and withdrawal?
        //make sure to dump some execption catchers into the streamwriter
        //put the generate-account-number in Accounts, then assign it here (?)

        //CONSTRUCTOR
        public Clients()
        {
            //default constructor
        }
        public Clients(string cliName, string cliNumber )//more useful constructor
        {
            this.ClientName = cliName;
            this.AcctNumber = cliNumber;
        }
    }
}
