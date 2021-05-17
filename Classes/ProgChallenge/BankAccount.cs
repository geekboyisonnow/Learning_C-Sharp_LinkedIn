using System;

namespace ProgChallenge
{
    public class BankAccount
    {
        private string _firstname;
        private string _lastname;

        public decimal Balance { get; set; }

        public BankAccount(string firstname, string lastname, decimal initialbalance=0.0m) {
           _firstname = firstname;
           _lastname = lastname;
           Balance = initialbalance;
        }

        // Get & Set; First & Last Names
        public string AccountOwner {
            get => $"{_firstname} {_lastname}";
        }

        public virtual void Deposit(decimal amount) {
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount) {
            Balance -= amount;
        }
    }
}