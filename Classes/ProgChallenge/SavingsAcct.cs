using System;

namespace ProgChallenge
{
    public class SavingsAcct : BankAccount
    {
        private int _withdrawaccount = 0;
        private const decimal WITHDRAW_CHARGE = 2.0m;
        private const int WITHDRAW_LIMIT = 3;

        // use the base() keyword to initialize the base class
        public SavingsAcct(string firstname, string lastname, decimal interest, decimal initialbalance) 
        : base(firstname, lastname, initialbalance)
        {
            InterestRate = interest;
        } 

        public decimal InterestRate {
            get; set;
        }

        // TODO: use the override keyword to override a base class method
        public void ApplyInterest()
        {
            // Add the new amount to the existing balance
            Balance += (Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance) {
                Console.WriteLine("Attempt to overdraw savings - denied!");
            }
            else {
                base.Withdraw(amount);

                // Charge for more than 3 Withdrawals
                _withdrawaccount++;
                if (_withdrawaccount > WITHDRAW_LIMIT) {
                    Console.WriteLine("More than 3 withdrawals - extra charge");
                    base.Withdraw(WITHDRAW_CHARGE);
                }
            }
        }
    }
}