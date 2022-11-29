using System.Threading;
using System.Xml.Linq;


namespace Atena.Delegate.Lesson
{
    class PrelievoBanca
    {
        public class Conto: IContoNazionale
        {   
            public string Name { get; set; }    
            public COUNTRY _cOUNTRY { get; } = COUNTRY.IT;

            public void Withdraw(decimal amount, Conto banca    ) 
            {
                System.Console.WriteLine($"Prelievo effettuato per cliente della banca {banca.Name}");
            }
            public void Deposit(decimal amount, Conto banca) 
            {
                if (banca.Name != this.Name  )
                {
                    System.Console.WriteLine($"non è possbile efettuare deposito in una banca diversa dalla tua.");
                }
                else
                {
                    System.Console.WriteLine($"Versamento effettuato di EURO {amount}");   
                }
            }
            public void FiscalInfo(Conto banca) 
            {

            }
            public void IntenationalWithdraw(decimal amount, Conto banca) { }

        }   
        internal interface IContoNazionale : IContoInternazionale
        {
           
            public void Deposit(decimal amount, Conto banca);
            public void FiscalInfo(Conto banca);
        }
        internal interface IContoInternazionale
        {
            public void Withdraw(decimal amount, Conto banca); 
        }
        class ATMGermania : IContoNazionale
        {
            private COUNTRY _cOUNTRY { get; } = COUNTRY.DE;
            
            public void Withdraw(decimal amount, Conto banca)
            {
                if(banca._cOUNTRY == _cOUNTRY)
                {
                    
                    Withdraw(amount, banca);

                }
                else
                {
                    var b = (IContoInternazionale) banca;// Castrazione ! 
                    IntenationalWithdraw(amount, b);
                }               
            }
            
            public void Deposit(decimal amount, Conto banca) { }
            public void FiscalInfo( Conto banca) 
            {
                if (banca._cOUNTRY != _cOUNTRY)
                {
                    System.Console.WriteLine($"Is not possbible to access fiscal data for internatioanle Customer");
                }
                
            }

            // Funzione solo per il prelievo internazionale
            void IntenationalWithdraw(decimal amount, IContoInternazionale bancaInternazionale)
            {
                var b = (Conto) bancaInternazionale;                
                bancaInternazionale.Withdraw(amount, b);
            }
        }
        class Client
        {
            public void Withdraw()
            {
                Conto unicredit = new Conto();
                ATMGermania aTMGermania = new ATMGermania();

                aTMGermania.Withdraw(1000, unicredit);
            }
        }
        public enum COUNTRY
        {
            DE,
            IT,
            FR,

        }
    } 

    
    
}