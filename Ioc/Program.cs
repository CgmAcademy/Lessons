using System;

namespace Ioc
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // CONCRETE SERVICE CREATION AND INJECTION
            TicketCreator client1 = new TicketCreator();
           // TicketCreator client2 = new TicketCreator();
            //client1.Purchase(new AirFranceTicket()); // Client is Choosing the Service Provider. 
          //  client2.Purchase(new AirFranceTicket()); // Client is Choosing the Service Provider. 

        

            //  SERVICE CREATION AND INJECTION THROUGH THE FACTORY
            client1.Purchase(EUTicketFactory.GetSituation()); // Client delegates the choice to the Factory Provider

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

    public class EUTicketFactory//  Inject the concrete object to the TicketCreator 
    {
        public static FlightTicket GetSituation()
        {
            switch (EuropeanUnion.Positive)
            {
                case > 50000:
                    return new RedZone().GetCompany();
                case > 20000:
                case < 50000:
                    return new OrangeZone().GetCompany();

                default:
                    return null;
            }
        }
    }
    abstract class EUCovidRestriction
    {
        public abstract FlightTicket GetCompany();
    }
    class RedZone : EUCovidRestriction
    {
        public override FlightTicket GetCompany() { return new AirFranceTicket(); }
    }
    class OrangeZone : EUCovidRestriction
    {
        public override FlightTicket GetCompany() { return new KlmTicket(); }
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
