﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Classes
{
    public class BankAccount
    {
        private double balance;

        public double Balance // propfull
        {
            get
            {
                if (balance < 1000000)
                    return balance;
                return 1000000;
            }
            set
            {
                if (value > 0)
                    balance = value;
                balance = 0;
            }
        }

        public double AddToBalance(double balanceToBeAdded)
        {
            Balance += balanceToBeAdded;
            return Balance;
        }
    }
}
