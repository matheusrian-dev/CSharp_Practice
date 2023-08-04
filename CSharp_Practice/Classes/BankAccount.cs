using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Interfaces;

namespace CSharp_Practice.Classes
{
    public class BankAccount : IInformation
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
            protected set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public BankAccount() //ctor
        {
            Balance = 100;
        }

        public BankAccount(double initialbalance)
        {
            Balance = initialbalance;
        }

        public virtual double AddToBalance(double balanceToBeAdded)
        {
            Balance += balanceToBeAdded;
            return Balance;
        }

        public string GetInformation()
        {
            return $"Seu saldo atual é: {Balance:c}";
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            Balance = 40;
        }

        public override double AddToBalance(double balanceToBeAdded) // Exemplo de override (sobreposição)
        {
            if (balanceToBeAdded > 1000)
                balanceToBeAdded = 1000;
            if (balanceToBeAdded < -1000)
                balanceToBeAdded = -1000;
            return base.AddToBalance(balanceToBeAdded);
        }
    }
}
