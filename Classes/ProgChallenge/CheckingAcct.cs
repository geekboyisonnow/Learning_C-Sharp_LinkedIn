using System;

namespace ProgChallenge
{
    public class CheckingAcct : AccountOwner
    {
     // TODO: Declare "CheckingAcct" as a subclass of AccountOwner
        
            private decimal _initialbalance;

            // TODO: use the base() keyword to initialize the base class
            public CheckingAcct(string name, string firstname, string lastname, decimal initialbalance) 
            : base(name, firstname, lastname)
            {
                _initialbalance = initialbalance;
            }

            public decimal InitialBalance {
                get => _initialbalance;
                set => _initialbalance = value;
            }     
    }
}