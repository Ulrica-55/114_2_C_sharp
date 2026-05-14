using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    class BankAccount
    {
       private decimal balance;
        // Constructor that sets the starting balance.
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }
        // Method to deposit money into the account.
        public decimal Balance
        {
            get { return balance; }
        }
        // Method to deposit money into the account.
        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                balance += amount;
            }
        }
        // Method to withdraw money from the account.
        public void Withdraw(decimal amount)
        {
            if(amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else if (amount<= 0)
            {
                MessageBox.Show("提款金額必須為正數");
            }
            else 
            {
                MessageBox.Show("提款金額不能超過帳戶餘額");
            }
        }
        // Method to get the current balance.
        public decimal GetBalance()
        {
            return balance;
        }
    }
}
