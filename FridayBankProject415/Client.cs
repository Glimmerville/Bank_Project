using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FridayBankProject415
{
    class Client
    {
        //field
        //private string clientFirstName;
        //private string clientLastName;
        private string clientName;
        private string acctNumber;

        //properties
        //public string ClientFirstName { get { return this.clientFirstName; } set { this.clientFirstName = value; } }
        //public string ClientLastName { get { return this.clientLastName; } set { this.clientLastName = value; } }
        public string ClientName { get { return this.clientName; } set { this.clientName = value; } }
        public string AcctNumber { get { return this.acctNumber; } set { this.acctNumber = value; } }

        //methods
        public static string FullName(string first, string last)
        {
            string ClientFullName = first + " " + last;
            return ClientFullName;
        }
        //constructor
        public Client()
        {
            //default constructor
        }
        public Client(string cliName, string cliNumber)//more useful constructor
        {
            this.ClientName = cliName;
            this.AcctNumber = cliNumber;  
        }
    }
}
