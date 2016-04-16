using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayBankProject415
{
    class Checking:Account
    {
        //field 
        public new string Output = @"CheckingSummary.txt";
        public new string serviceName = "Checking";
        private double checkingBalance;

        public new double ClientBalance { get { return this.checkingBalance; } set { this.checkingBalance = value; } }
        
    }
}
