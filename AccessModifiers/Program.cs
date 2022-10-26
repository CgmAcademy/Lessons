using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public abstract class Bank
    {
        protected string name;              
        protected decimal debt;
        protected decimal saldo;
        public abstract decimal Saldo { get;  }   
        public abstract decimal Debt();

    }
    public class CentralBank : Bank
    {
        public  override decimal Saldo { get { return Debt(); }  }
        public sealed override decimal Debt()
        {
            return saldo - debt;
        }
    }
    public class CommecialBank : Bank
    {
        decimal interest;
        public override decimal Saldo { get { return saldo + interest; }  }
        public sealed override decimal Debt()
        {
            return saldo - 1000.00M;
        }
        private decimal CalcInterest()
        {
            return interest+= 1.0M;
        }
        public decimal Deposit(decimal amount)
        {
            return saldo += amount;
        }
        public decimal WithDraw(decimal amount)
        {
            return saldo -= amount;
        }
    }
    public class EuroCentralBank : CentralBank
    {    

      //  public override string Debt() { }
    }
    public class FEDCentralBank : CentralBank
    {
        public override decimal Saldo { get { return saldo; } }

       // public override string Debt() { }
    }
}
