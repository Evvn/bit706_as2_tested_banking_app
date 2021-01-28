using Microsoft.VisualStudio.TestTools.UnitTesting;
using banking_app;
using System;

namespace account_tests
{
    [TestClass]
    public class AccountUnitTests
    {
        [TestMethod]
        public void Account_create_with_balance()
        {
            //arrange
            Account a = new Everyday(1130);


            //act


            //assert
            decimal expected = 1130;
            decimal actual = a.Balance;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Account_withdraw_with_balance()
        {
            //arrange
            Account a = new Everyday(1000);
            decimal withdrawal = 200;

            //act
            a.Withdraw(withdrawal);

            //assert
            decimal expected = 800;
            decimal actual = a.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_withdraw_without_balance()
        {
            //arrange
            Account a = new Everyday(200);
            decimal withdrawal = 500;

            string actual;
            //act
            try
            {
                actual = a.Withdraw(withdrawal);
                Assert.Fail(); // will not reach here if correct
            }
            catch (Exception e)
            {
                actual = e.Message;
            }

            string expected = "Everyday " + a.ID.ToString() + "; withdrawal $500; transaction failed; balance $200";


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_deposit_to_balance()
        {
            //arrange
            Account a = new Everyday(1000);


            //act
            a.Deposit(200);

            //assert
            decimal expected = 1200;
            decimal actual = a.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_get_info_string()
        {
            //arrange
            Account a = new Everyday(1130);


            //act
            string expected = "Account " + a.ID.ToString() + "; Balance $1130";
            string actual = a.GetInfo();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_print_as_readable_string()
        {
            //arrange
            Account a = new Everyday(1130);


            //act
            string expected = "Everyday " + a.ID.ToString();
            string actual = a.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_create_investment_account_with_fail_fee()
        {
            //arrange
            Account a = new Investment(1000, (decimal).10, 10);


            //act
            decimal expected = 10;
            decimal actual = a.FailFee;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_failed_withdrawal_with_fail_fee()
        {
            //arrange
            Account a = new Investment(1000, (decimal).10, 10);

            //act
            try
            {
                a.Withdraw(1500);
            }
            catch (Exception e)
            {
                // should throw exception, and reduce balance by fail fee
                string exc = e.Message;
            }

            //assert
            decimal expected = 990;
            decimal actual = a.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_create_with_interest()
        {
            //arrange
            Account a = new Investment(1000, (decimal).10, 10);

            //act
            decimal expected = (decimal).10;
            decimal actual = a.InterestRate;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_calculate_interest()
        {
            //arrange
            Account a = new Investment(1000, (decimal).10, 10);

            //act
            a.GetInterest();

            //assert
            decimal expected = 1100;
            decimal actual = a.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_create_with_overdraft()
        {
            //arrange
            Account a = new Omni(1000, (decimal).10, 10, 100);

            //act
            decimal expected = 100;
            decimal actual = a.OverdraftLimit;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_withdraw_within_overdraft_limit()
        {
            //arrange
            Account a = new Omni(1000, (decimal).10, 10, 100);

            //act
            a.Withdraw(1050);

            //assert
            decimal expected = -50;
            decimal actual = a.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Account_withdraw_outside_overdraft_limit()
        {
            //arrange
            Account a = new Omni(1000, (decimal).10, 10, 100);

            //act
            string actual;
            try
            {
                actual = a.Withdraw(1150);
                Assert.Fail(); // should throw exception, if code reaches here fail test
            }
            catch (Exception e)
            {
                actual = e.Message;
            }

            //assert
            string expected = "Omni " + a.ID.ToString() + "; withdrawal $1150; transaction failed; fee 10; balance $990";
            Assert.AreEqual(expected, actual);
        }

    }
}
