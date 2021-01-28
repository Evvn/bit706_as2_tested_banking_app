using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{
    public abstract class Account
    {
        static int nextAccountId = 1;
        protected int accountId;
        protected decimal balance;
        protected decimal interestRate;
        protected decimal failFee;
        protected decimal overdraftLimit;

        public Account()
        {
            accountId = nextAccountId;
            nextAccountId++;
        }

        public Account(decimal startingBalance) : this()
        {
            balance = startingBalance;
        }

        public decimal Balance { get => balance; set => balance = value; }
        public int ID { get => accountId; }

        public decimal InterestRate { get => interestRate; set => interestRate = value; }
        public decimal FailFee { get => failFee; set => failFee = value; }
        public decimal OverdraftLimit { get => overdraftLimit; set => overdraftLimit = value; }



        public virtual string Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                string transactionResult = "Account " + accountId.ToString() + "; withdrawal $" + amount.ToString() + "; balance $" + (balance - amount).ToString();
                balance -= amount;
                return transactionResult;
            }
            else
            {
                string transactionResult = "Account " + accountId.ToString() + "; withdrawal $" + amount.ToString() + "; transaction failed";
                throw new Exception(transactionResult);
            }
        }

        public virtual string Deposit(decimal amount)
        {
            string transactionResult = "Account " + accountId.ToString() + "; deposit $" + amount.ToString() + "; balance $" + (balance + amount).ToString();
            balance += amount;
            return transactionResult;
        }

        public virtual string GetInterest()
        {
            return "This account type does not accrue interest";
        }

        public virtual string GetInfo()
        {
            return "Account " + accountId.ToString() + "; Balance $" + balance.ToString();
        }

        public override string ToString()
        {
            return "Account " + accountId.ToString();
        }
    }

    public class Everyday : Account
    {
        static readonly string accountType = "Everyday";

        public Everyday(decimal startingBalance) : base(startingBalance) { }

        public override string Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                string transactionResult = accountType + " " + accountId.ToString() + "; withdrawal $" + amount.ToString() + "; balance $" + (balance - amount).ToString();
                balance -= amount;
                return transactionResult;
            }
            else
            {
                string transactionResult = accountType + " " + accountId.ToString() + "; withdrawal $" + amount.ToString() + "; transaction failed; balance $" + balance.ToString();
                throw new Exception(transactionResult);
                //return transactionResult;
            }
        }

        public override string Deposit(decimal amount)
        {
            string transactionResult = accountType + " " + accountId.ToString() + "; deposit $" + amount.ToString() + "; balance $" + (balance + amount).ToString();
            balance += amount;
            return transactionResult;
        }

        public override string ToString()
        {
            return accountType.ToString() + " " + accountId.ToString();
        }
    }

    public class Investment : Account
    {
        static readonly string accountType = "Investment";

        public Investment(decimal startingBalance) : base(startingBalance) { }

        public Investment(decimal startingBalance, decimal setInterestRate, decimal setFailFee) : this(startingBalance)
        {
            interestRate = setInterestRate;
            failFee = setFailFee;
        }

        public override string GetInterest()
        {          
            decimal interest = Math.Round(balance * interestRate, 2);
            string transactionResult = accountType + " " + accountId.ToString() + "; Add interest $" + interest.ToString() + "; balance $" + (balance + interest).ToString();
            balance += interest;
            return transactionResult;
        }

        public override string Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                string transactionResult = accountType + " " + accountId.ToString() + "; withdrawal $" + amount.ToString() + "; balance $" + (balance - amount).ToString(); 
                balance -= amount;
                return transactionResult;
            }
            else
            {
                string transactionResult = accountType + " " + accountId.ToString() + "; withdrawal $" + amount.ToString() + "; transaction failed; fee " + failFee.ToString() + "; balance $" + (balance - failFee).ToString();
                balance -= FailFee;
                throw new Exception(transactionResult);
                // return transactionResult;
            }
        }

        public override string Deposit(decimal amount)
        {
            string transactionResult = accountType + " " + accountId.ToString() + "; deposit $" + amount.ToString() + "; balance $" + (balance + amount).ToString();
            balance += amount;
            return transactionResult;
        }

        public override string GetInfo()
        {
            return accountType + " " + accountId.ToString() + "; Interest rate %" + (interestRate*100).ToString() + "; Fee $ " + failFee.ToString() + "; Balance $" + balance.ToString();
        }

        public override string ToString()
        {
            return accountType.ToString() + " " + accountId.ToString();
        }
    }

    public class Omni : Account
    {
        static readonly string accountType = "Omni";

        public Omni(decimal startingBalance) : base(startingBalance) { }

        public Omni(decimal startingBalance, decimal setInterestRate, decimal setFailFee, decimal setOverdraftLimit) : this(startingBalance)
        {
            interestRate = setInterestRate;
            failFee = setFailFee;
            overdraftLimit = setOverdraftLimit;
        }

        public override string GetInterest()
        {
            decimal overLimit = balance - 1000;
            if (overLimit <= 0)
            {
                return "Interest only applies on amounts over $1000";
            }
            decimal interest = Math.Round(overLimit * interestRate, 2);
            string transactionResult = accountType + " " + accountId.ToString() + "; Add interest $" + interest.ToString() + "; balance $" + (balance + interest).ToString();
            balance += interest;
            return transactionResult;
        }

        public override string Withdraw(decimal amount)
        {
            if (amount <= balance + overdraftLimit)
            {
                string transactionResult = accountType + " " + accountId.ToString() + "; withdrawal $" + amount.ToString() + "; balance $" + (balance - amount).ToString();
                balance -= amount;
                return transactionResult;
            }
            else
            {
                string transactionResult = accountType + " " + accountId.ToString() + "; withdrawal $" + amount.ToString() + "; transaction failed; fee " + failFee.ToString() + "; balance $" + (balance - failFee).ToString();
                balance -= FailFee;
                throw new Exception(transactionResult);
                // return transactionResult;
            }
        }

        public override string Deposit(decimal amount)
        {
            string transactionResult = accountType + " " + accountId.ToString() + "; deposit $" + amount.ToString() + "; balance $" + (balance + amount).ToString();
            balance += amount;
            return transactionResult;
        }

        public override string GetInfo()
        {
            return accountType + " " + accountId.ToString() + "; Interest rate %" + (interestRate * 100).ToString() + "; Overdraft limit $" + overdraftLimit.ToString() + "; Fee $ " + failFee.ToString() + "; Balance $" + balance.ToString();
        }

        public override string ToString()
        {
            return accountType.ToString() + " " + accountId.ToString();
        }
    }
}
