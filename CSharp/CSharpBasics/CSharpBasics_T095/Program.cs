using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account aA = new Account(101,5000);
            Account aB = new Account(102,5000);

            AccountManager amA = new AccountManager(aA, aB, 1000);
            Thread T1 = new Thread(amA.Transfer);
            T1.Name = "T1";

            AccountManager amB = new AccountManager(aA, aB, 1000);
            Thread T2 = new Thread(amB.Transfer);
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

        public Account(int id, double balance)
        {
            _id = id;
            _balance = balance;
        }

        public void Withdraw(double amount){
            _balance -= amount;
        }

        public void Deposit(double amount){
            _balance += amount;
        }
    }
    
    // It will generate dead lock
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
            lock(_fromAccount){
                Thread.Sleep(1000);
                lock(_toAccount){
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
    }
}
