using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class SavingsAccount : BankAccount 
    {
        public decimal InterestRate { get; private set; }
        public SavingsAccount(string owner, decimal interestRate) : base(owner + $" {interestRate}%")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal sumToDeposit)
        {
     
            if (sumToDeposit <= 0)
                return $"You can not deposit {sumToDeposit}";
            if (sumToDeposit > 20000)
                return $"Deposit limit reached";

            decimal interestRate = (InterestRate / 100) * sumToDeposit;

            Balance += sumToDeposit + interestRate;
            return $"{sumToDeposit} deposited succesfully to {Owner} account!";

        }
    }
}
