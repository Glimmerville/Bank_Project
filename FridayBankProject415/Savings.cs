using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayBankProject415
{
    class Savings:Account
    {
        //field 
        public new string Output  = @"SavingsSummary.txt";
        public new string serviceName = "Savings";
        private double savingsBalance;


        public new double ClientBalance { get { return this.savingsBalance; } set { this.savingsBalance = value; } }
       
    }
}
