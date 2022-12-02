using AbstractFactory.AbsClass;
using AbstractFactory.AbsFactory;
using AbstractFactory.ConcreteClass;
using AbstractFactory.Enums;

namespace AbstractFactory.ConcreteFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>

    class TravelFactory : AbstractTravelFactory
    {
        object _country;
        public TravelFactory(object country)
        {
            _country=country;   
        }
        public override CovidFactory GetRestrictionInfo()
        {

            switch (_country)
            {
                case EUROPE:
                    return new Redzone();
                case NA:
                    return new  Yellowzone(); 
                    default:
                    return null; 
            }
            //return new Redzone();
        }
        public override TrainAgencyFactory CreateTravel()
        {
            return new OOB();
        }
    }  
   
}
