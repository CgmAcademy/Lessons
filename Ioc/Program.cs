using System;

namespace Ioc
{
    internal class Program
    {
        static void Main(string[] args)
        { 


            // CONCRETE SERVICE CREATION AND INJECTION
            TicketCreator client1 = new TicketCreator(); 
            TicketCreator client2 = new TicketCreator();
            client1.Purchase(new AirFranceTicket()); // Client is Choosing the Service Provider. 
            client2.Purchase(new AirFranceTicket()); // Client is Choosing the Service Provider. 



            //  SERVICE CREATION AND INJECTION THROUGH THE FACTORY
            client1.Purchase(EUAirCompanyFactory.Create()); // Client delegates the choice to the Factory Provider
          
        }
    }
    public class TicketCreator
    {
        public void Purchase(FlightTicket travelAgency) //  Inject the abstract object to client 
        {   
            // Do some conditions 
            travelAgency.CreateTravel();// Create the 
        }
    }


    public class EUAirCompanyFactory
    {
        public static FlightTicket Create()
        {
            Console.WriteLine("Created by EUAirCompany Factory");
            return EUCovidRestriction.GetSituation(); 
        }
    }
    public class EUCovidRestriction//  Inject the concrete object to the TicketCreator 
    {       
        public static FlightTicket GetSituation()
        {
            switch (EuropeanUnion.Positive)
            {
                case > 50000:
                    return new AirFranceTicket();
                case > 20000:
                case < 50000:
                    return new KlmTicket();
                   
                default:
                    return null;
            }
        }
    } 
   
    public class EuropeanUnion
    {
        public static int Positive { get; } = 30000;          
    }

    
    public class FlightTicket
    {
        public FlightTicket()
        {

        }
        public virtual void CreateTravel() { }
    }
    public class AirFranceTicket : FlightTicket
    {
        string name;
        public override void CreateTravel()
        {
            Console.WriteLine("Created with AirFrance");
        }
    }
    public class KlmTicket : FlightTicket
    {
        string name;
        public override void CreateTravel()
        {
            Console.WriteLine("Created with KLM");
        }
    }

}
