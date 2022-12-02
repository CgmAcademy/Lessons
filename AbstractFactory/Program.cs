using System;
using AbstractFactory.AbsFactory;
using AbstractFactory.Client;
using AbstractFactory.ConcreteFactory;
using AbstractFactory.Enums;

namespace AbstractFactory
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Abstract Factory Design Pattern.
    /// </summary>

    class MainApp
    {
      
        public static void Main() // Front end 

        {
           
            WorldTravel world ;       
            AbstractTravelFactory Italy = new TravelFactory(NA.USA);
            world = new WorldTravel(Italy);
            world.RunTravelCheckIn();

            Console.ReadKey();
        }
    }
}
