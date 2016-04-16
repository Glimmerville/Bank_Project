using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayBankProject415
{
    class Reserve:Account
    {
        //field 
        public new string Output = @"ReserveSummary.txt";
        public new string serviceName = "Reserve";
        private double reserveBalance;


        public new double ClientBalance { get { return this.reserveBalance; } set { this.reserveBalance = value; } }
    }
}
