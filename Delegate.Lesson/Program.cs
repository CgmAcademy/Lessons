
using System;
using static Atena.Delegate.Lesson.Program;

namespace Atena.Delegate.Lesson
{
    
    public delegate string EUDigitalWalletAction();

    internal class Program
    {

        static void Main(string[] args)
        {
            EUDigitalWallet personalWallet = new EUDigitalWallet();
            AssicurazioneSanitaria allianz = new AssicurazioneSanitaria();
            EUDigitalWalletAction datiSanitari = personalWallet.GetSituazioneSanitaria;
          //  NotificationAction notificationAction = Notification;

            allianz.Create(datiSanitari); 
            allianz.Delete(Notification);

        }
        public static void Notification(string msg) // Callback
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor(); 
        }
    } 
    public class EUDigitalWallet
    {
        string _diploma;
        string _dichiarazioneReddito;
        string _fedinaPenale; 
        string _cartellaClinica = "Situazione sanitaria è OK";  

        public string GetIstruzione()
        {
            return _diploma;   
        }
        public string GetReddito()
        {
            return _dichiarazioneReddito;
        }
        public string GetSituazionePenale()
        {
            return _fedinaPenale;
        }
        public string GetSituazioneSanitaria()
        {
            return _cartellaClinica;
        }
    }
    public class AssicurazioneSanitaria 
    {
       public void Create(EUDigitalWalletAction personalWallet) 
       {
            Console.WriteLine(personalWallet());          
       }
       public void Delete(Action<string> notificationAction) 
       {
            Console.ForegroundColor = ConsoleColor.Red; 
            notificationAction("Cancellazione eseguita! ");
            Console.ResetColor(); 
       }
    }
    
}