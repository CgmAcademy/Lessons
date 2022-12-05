using System;

namespace AbstractFactory.AbsClass
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>

    abstract class TrainAgencyFactory
    {
        public virtual void Needs(CovidFactory zone) // dipendenza 
        {
            GetTravelCompany();
            Console.Write( GetType().Name  + " needs ");
            zone.Needs();
        } 
        void GetTravelCompany()
        {
            Console.WriteLine("Viaggerai con la compania " + GetType().Name);
        }

    }
    
    
}
