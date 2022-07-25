using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTestClass
{
    public class Borrower
    {
        public double amount;


        public Borrower(double amount)
        {
            this.amount = amount;
        }

        public void askForMoreMoney(double amount)
        {
            this.amount += amount;
        }

        public double returnBalance()
        {
            return amount;
        }
    }
}
