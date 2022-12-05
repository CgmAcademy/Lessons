using Delegate.Lesson;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Delegate.Lesson
{

    public delegate string EUDigitalWalletAction();
    public delegate void DelMessage();
    // public delegate void NotificationAction(string mgs);
    internal class Program
    {

        static void Main(string[] args)
        {
            EUDigitalWallet personalWallet = new EUDigitalWallet();
            AssicurazioneSanitaria allianz = new AssicurazioneSanitaria();


            EUDigitalWalletAction multidel, datiSanitari, DatiPenali;
            datiSanitari = personalWallet.GetSituazioneSanitaria;
            DatiPenali = personalWallet.GetSituazionePenale;

            //Multidel
            multidel = DatiPenali ;
            multidel += datiSanitari;



            // Anonymous Delegate
            multidel += ()=> { return "Anonymous Delegate"; };


            Action<string> action = (s) => { };

            multidel(); // Eseguo il MultiDelegate
            Console.WriteLine("---------------------");
            allianz.Create(multidel); // eseguo tutti le function dendro il delegate

            // Func Delegate return a String 
            Func<string> getRandomNumber = delegate ()
            {                 
               Random rnd = new Random();               
               return  rnd.Next(1, 100).ToString();
            };


            // Func Delegate return a String  and Accept an 'int' parameter
            Func<int, string> random = (x) => {
                Random rnd = new Random();
                return rnd.Next(1, 100).ToString();
            };


          //  multidel += new EUDigitalWalletAction(getRandomNumber);


            // Fucniton delgate with Anonymous Function
            Func<int, int, string> Sum = (x, y) => (x + y).ToString();

          


            TryPredicate();


            //  NotificationAction notificationAction = Notification;
            //  Console.WriteLine(multidel());
            // Console.WriteLine(multidel());
        //    allianz.Create(multidel);
            //allianz.Delete((msg) =>
            //{
            //    Console.ForegroundColor = ConsoleColor.Magenta;
            //    Console.WriteLine(msg);
            //    Console.ResetColor();
            //});


            

           


            //Console.WriteLine(MultiMsg());
        }
        public static void Notification(string msg) // Callback
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor(); 
        } 
        public static void TryPredicate()
        {
            Point[] points = { new Point(100, 200),
                         new Point(150, 250), new Point(250, 375),
                         new Point(275, 395), new Point(295, 450) };

            // Define the Predicate<T> delegate.
            Predicate<Point> predicate = FindPoints;

            // Find the first Point structure for which X times Y
            // is greater than 100000.
            Point first = Array.Find(points, predicate);

            // Display the first structure found.
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);
        }

        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 100000;
        }
    }
        
    } 
    public class EUDigitalWallet
    {
        string _diploma;
        string _dichiarazioneReddito;
        string _fedinaPenale = "Situazione PENALE è OK";
        string _cartellaClinica = "Situazione SANITARIA è OK";  

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
            // Console.WriteLine(personalWallet());


            // If the delegate invocation includes output parameters or a return value,
            // their final value will come from the invocation of the last delegate in the list.
            foreach (EUDigitalWalletAction myDlgt in personalWallet.GetInvocationList())
            {
                Console.WriteLine(myDlgt());
            }
        }
       public void Delete(Action<string> notificationAction) 
       {
            Console.ForegroundColor = ConsoleColor.Red; 
            notificationAction("Cancellazione eseguita! ");
            Console.ResetColor(); 
       }
    }

class TimerDelegate
{
    static void SetTimer(string[] args)
    {
        Console.WriteLine("##### Working with TimerCallback Delegate #####\n");

        // Create the delegate for the Timer type. 
        TimerCallback timeCB = new TimerCallback(PrintTime);

        // Configuring timer settings. 
        Timer t = new Timer(
                   timeCB,       // The TimerCallback delegate type.
                   "Hi, Thanks",// Any info to pass into the method called.
                     5000,        //  Time to wait before starting.
                    5000);    // Interval of time between calls. 

        Console.WriteLine("Press any key to terminate...");
        Console.ReadLine();
    }
    static void PrintTime(object state)
    {
        Console.WriteLine("Time is: {0}, Parameter is: {1}",
                         DateTime.Now.ToLongTimeString(), state.ToString());
    }
}