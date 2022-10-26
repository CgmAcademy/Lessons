namespace Associatons.Composition
{
    public class Company
    {
        public CEO _CEO;
        public decimal salary;
        public Company(string ceo)
        {
            _CEO = new CEO(ceo);
        }        

    } 
    public class CEO 
    {
        public CEO(string Name)
        {

        }
    }
}

