namespace AbstractInterface.Lesson
{
    public interface IONU
    {
        public void PopulationControl(); 
        public void TerritoryControl();
    }
    public interface IEuropeanUnion
    {
        public void EUConstitution();
    }
    public interface IEuroZone : IEuropeanUnion
    {
        public void EuroCurrency();
    }
    public class Country : IONU
    {
        public void PopulationControl() { }
        public void TerritoryControl() { }

    }
    public class EUCountry : Country, IEuropeanUnion
    {
        public void EUConstitution() { }
    }
    public class EuroZoneCountry : EUCountry, IEuroZone
    {
        public void EuroCurrency() { }
    }

}

