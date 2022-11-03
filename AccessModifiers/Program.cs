using System;
using System.Linq;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommecialBank Ingbank = new CommecialBank();
          
            Ingbank.Withdraw(100.00m, "IT19415121258885"); 
        }
    }
    public abstract class Bank
    {
        public string name;
        protected abstract decimal Debt(); 
        
    }
    public  class CentralBank : Bank
    {
        protected decimal saldo;
        protected decimal debt;
      
        protected sealed override decimal Debt()
        {
            return saldo - debt;
        }
    }
    public class CentralBankEurope : CentralBank
    {
        protected decimal saldo;
        protected decimal debt;

        protected override decimal Debt() // Errore -> non è possibile fare l'overrride di Sealed
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
            return interest += 1000000M;
        }
        //private void GetAccount(string AccountNmbr)
        //{
        //    if (index < _acconts.Length)
        //        _acconts[index] = new Account(AccountNmbr);

        //}
        public void Withdraw(decimal amount, string accountNmb)
        {
            Account account1 = new Account(accountNmb);
            _acconts[0] = account1;
              
           // int index = Array.FindIndex(_acconts, row =>  row != null && row._accountN == accountNmb );
            //  Account account = _acconts.Where(i => i._accountN == accountNmb).FirstOrDefault();
            //return account.Deposit(amount);
           
        

        class Account
        {
            
            public decimal saldo;
            public string _accountN;
            public Account(string accountNmb)
            {
                _accountN = accountNmb;
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
