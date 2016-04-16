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

        //constructor
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
