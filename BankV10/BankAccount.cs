using System;
using System.Runtime.Remoting.Services;

namespace BankV10
{
    public class BankAccount
    {
        #region Instance fields
        private double _balance;
        public string error = "enter a valid amount";
        #endregion

        #region Constructor
        public BankAccount()
        {
            _balance = 0.0;
        }
        #endregion

        #region Properties
        public double Balance
        {
            get { return _balance; }
        }
        #endregion

        #region Methods
        //Need to make it so that method detects error in the logic and sends error msg instead
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                _balance = _balance + amount;
            }
        }

        public void Withdraw(double amount)
        {
            if ((_balance >= amount) && (amount >= 0.0) )
            {
                _balance = _balance - amount;
            }
        }
        #endregion
    }
}