using AbstractFactory.AbsClass;
using AbstractFactory.AbsFactory;


namespace AbstractFactory.Client
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>

    class WorldTravel
    {
        private CovidFactory _restriction;
        private TrainAgencyFactory _travel;

        // Constructor

        public WorldTravel(AbstractTravelFactory factory)
        {
            _travel = factory.CreateTravel();
            _restriction = factory.GetRestrictionInfo(); // 
        }

        public void RunTravelCheckIn()
        { 
            //Mock Restrictions info my own data. 
            _travel.Needs(_restriction);
        }
    }
}
