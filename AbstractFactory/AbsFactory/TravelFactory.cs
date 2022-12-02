using AbstractFactory.AbsClass;
using AbstractFactory.Enums;

namespace AbstractFactory.AbsFactory
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>

    abstract class AbstractTravelFactory
    {
        public abstract CovidFactory GetRestrictionInfo();
        public abstract TrainAgencyFactory CreateTravel();
    }
}
