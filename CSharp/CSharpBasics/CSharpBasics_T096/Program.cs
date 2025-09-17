using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T096
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account aA = new Account(101,5000);
            Account aB = new Account(102,5000);

            AccountManager amA = new AccountManager(aA, aB, 1000);
            Thread T1 = new Thread(aA.Transfer);
            T1.Name = "T1";

            AccountManager amB = new AccountManager(aA, aB, 1000);
            Thread T2 = new Thread(aB.Transfer);
            T2.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();
            
            // It will never end as both accounts are locked 
        }
    }

    class Account
    {
        private int _id;
        private double _balance;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public void Withdraw(double amount){
            _balance -= amount;
        }

        public void Deposit(double amount){
            _balance += amount;
        }
    }

    class AccountManager
    {
        Account _fromAccount, _toAccount;
        double _amountToTransfer;

        public AccountManager(Account fa, Account ta, double amount){
            _fromAccount = fa;
            _toAccount = ta;
            _amountToTransfer = amount;
        }

        public void Transfer(){
            object _lock1, _lock2;
            if (_fromAccount.ID<_toAccount.ID)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }
            
            lock(_lock1){
                Thread.Sleep(1000);
                lock(_lock2){
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
    }
}
