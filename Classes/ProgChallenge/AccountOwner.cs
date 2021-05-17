using System;

namespace ProgChallenge
{
    public class AccountOwner
    {
        private string _name;

        public AccountOwner(string name, string firstname, string lastname) {
           _name = name;
        }

        // Get & Set; First & Last Names
        public string FirstName {
            get; set;
        }

        public string LastName {
            get; set;
        }

        public string Name {
            // return the name
            get { return FirstName + " " + LastName; }
            
            // use the setter to validate the new property value
            set {
                if (value == "") {
                    throw new ArgumentException("Name cannot be blank");
                }
                _name = value;
            }
        }
    }
}