using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{
    class Customer
    {
        // unique customer id starting here
        static int nextCustomerId = 1;
        private int customerId;
        private string firstName;
        private string lastName;
        private int phoneNumber;
        private string email;
        private bool isBankStaff;
        private List<Account> accounts;

        public Customer()
        {
            // default constructor
            accounts = new List<Account>();
            // ensure customer id is unique and count ++
            customerId = nextCustomerId;
            nextCustomerId++;
        }

        public Customer(
            string setFirstName,
            string setLastName,
            int setPhoneNumber,
            string setEmail,
            bool setIsBankStaff) : this()
        {
            // constructor with params
            firstName = setFirstName;
            lastName = setLastName;
            phoneNumber = setPhoneNumber;
            email = setEmail;
            isBankStaff = setIsBankStaff;
        }

        public int CustomerId { get => customerId; }

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public string Email { get => email; set => email = value; }

        public bool IsBankStaff { get => isBankStaff; set => isBankStaff = value; }

        public List<Account> Accounts { get => accounts; set => accounts = value; }
    }
}
