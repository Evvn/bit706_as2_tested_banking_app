 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_app
{
    public partial class Form1 : Form
    {
        // init test customer
        private Customer Person = new Customer("Test", "Customer", 1300131313, "user@test.com", false);

        // init test customers accounts
        private Account Everyday = new Everyday(100);
        private Account Investment = new Investment(1000, (decimal).10, 10);
        private Account Omni = new Omni(500, (decimal).04, 5, 500);

        // init history
        private List<string> history = new List<string>();

        public Form1()
        {
            // add accounts to user
            Person.Accounts.Add(Everyday);
            Person.Accounts.Add(Investment);
            Person.Accounts.Add(Omni);

            InitializeComponent();
            ListAccounts();
            WriteUser();

        }

        private void ListAccounts()
        {
            foreach (Account a in Person.Accounts)
            {
                lstAccounts.Items.Add(a);
            }
        }

        private void WriteUser()
        {
            customerName.Text = "Customer: " + Person.FirstName + " " + Person.LastName;
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            Account selectedAcc = (Account)lstAccounts.SelectedItem;
            if (selectedAcc != null)
            {
                string output = selectedAcc.GetInfo();
                txtOutput.Text = output;
                lstHistory.Items.Add(output);
            } 
            else
            {
                txtOutput.Text = "Select an account first";
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Account selectedAcc = (Account)lstAccounts.SelectedItem;
            decimal input = numInput.Value;
            if (selectedAcc != null)
            {
                if (input > 0 && input <= 999999999)
                {
                    string output = selectedAcc.Deposit(input);
                    txtOutput.Text = output;
                    lstHistory.Items.Add(output);
                }
                else
                {
                    txtOutput.Text = "Enter a valid amount over 0 and less than 1b";
                }
            }
            else
            {
                txtOutput.Text = "Select an account first";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Account selectedAcc = (Account)lstAccounts.SelectedItem;
            decimal input = numInput.Value;
            if (selectedAcc != null)
            {
                if (input > 0 && input <= 999999999)
                {
                    try
                    {
                        string output = selectedAcc.Withdraw(input);
                        txtOutput.Text = output;
                        lstHistory.Items.Add(output);
                    }
                    catch (Exception ex)
                    {
                        txtOutput.Text = ex.Message;
                        lstHistory.Items.Add(ex.Message);
                    }
                }
                else
                {
                    txtOutput.Text = "Enter a valid amount between 0 and 1b";
                }
            }
            else
            {
                txtOutput.Text = "Select an account first";
            }
        }

        private void btnAddInterest_Click(object sender, EventArgs e)
        {
            Account selectedAcc = (Account)lstAccounts.SelectedItem;
            if (selectedAcc != null)
            {
                string output = selectedAcc.GetInterest();
                txtOutput.Text = output;
                lstHistory.Items.Add(output);
            }
            else
            {
                txtOutput.Text = "Select an account first";
            }
        }
    }
}
