namespace AbstractFactory.AbsClass
{
    
    abstract class CovidFactory
    {
        protected  string _restrictionType;
        public abstract void Needs();
    }
}
