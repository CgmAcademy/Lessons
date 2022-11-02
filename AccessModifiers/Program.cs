using System;
using System.Linq;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommecialBank Ingbank = new CommecialBank();
            Ingbank.GetAccount("IT19415121258885"); 
            Ingbank.Withdraw(100.00m, "IT19415121258885"); 
        }
    }
    public abstract class Bank
    {
        public string name;
        protected abstract decimal Debt();         
       
        //public decimal Withdraw(decimal amount, string accountNmb)
        //{
        //    Account account = new Account(accountNmb);
        //    return account.Deposit(amount);
        //}
        
    }
    public class CentralBank : Bank
    {
        protected decimal saldo;
        protected decimal debt;
      
        protected sealed override decimal Debt()
        {
            return saldo - debt;
        }
    }
    public class CommecialBank : Bank
    {
        decimal interest;
        decimal debt;
        int index = 0;
        Account[] _acconts = new Account[3];
        protected sealed override decimal Debt()
        {
            return  debt;
        }
        decimal CalcInterest()
        {
            return interest += 1.0M;
        }
        public void GetAccount(string AccountNmbr)
        {
            if (index < _acconts.Length)
                _acconts[index] = new Account(AccountNmbr);

        }
        public decimal Withdraw(decimal amount, string accountNmb)
        {
            Account account = _acconts.Where(i => i._accountNmb == accountNmb).FirstOrDefault();
            return account.Deposit(amount);
        }
        class Account
        {
            public decimal debt;
            public decimal saldo;
            public string _accountNmb;
            public Account(string accountNmb)
            {
                _accountNmb = accountNmb;
            }
            public decimal Deposit(decimal amount)
            {
                return saldo += amount;
            }
            public decimal Withdraw(decimal amount)
            {
                return saldo -= amount;
            }
        }
       
    }
    public class EuroCentralBank : CentralBank
    {
       // protected override string Debt() { }
    }
    public class FEDCentralBank : CentralBank
    {

       // public override string Debt() { }
    }
}
