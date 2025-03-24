using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string owner) 
        { 
            Owner = owner;
            AccountNumber = Guid.NewGuid();
        }

        public virtual string Deposit(decimal sumToDeposit)
        {
            if (sumToDeposit <= 0)
                return $"You can not deposit {sumToDeposit}";
            if (sumToDeposit > 20000)
                return $"Deposit limit reached";

            Balance += sumToDeposit;
            return $"{sumToDeposit} deposited succesfully to {Owner} account!";
        }

        public string Withdraw(decimal sumToDWithdraw)
        {
            if (sumToDWithdraw <= 0)
                return $"You can not withdraw {sumToDWithdraw}";
            if (Balance < sumToDWithdraw)
                return $"Not enough money to withdraw from {Owner}!";
                
            Balance -= sumToDWithdraw;
            return $"{sumToDWithdraw} withdrawn succesfully from {Owner} account!";        
        }
    }
}
