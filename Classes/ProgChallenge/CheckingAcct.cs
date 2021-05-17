using System;

namespace ProgChallenge
{
    public class CheckingAcct : BankAccount
    {
        private const decimal OVERDRAW_CHARGE = 35.0M;

        // TODO: Declare "CheckingAcct" as a subclass of BankAccount
        // use the base() keyword to initialize the base class
        public CheckingAcct(string firstname, string lastname, decimal initialbalance) 
        : base(firstname, lastname, initialbalance) {
        }

        public override void Withdraw(decimal amount) {
            // If the account gets OVERDRAWN add extra charge
            if (amount > Balance) {
                amount += OVERDRAW_CHARGE;
            }
            base.Withdraw(amount);
        } 
    }
}