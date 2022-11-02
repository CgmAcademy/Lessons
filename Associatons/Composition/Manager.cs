namespace Associatons.Composition
{
    public class Company
    {
        public CEO _CEO;
        public Company(string ceo)
        {
            _CEO = new CEO(ceo);
        } 
    }


    public class Labor
    {
        public string Name { get; set; }
    }
    public class CEO : Labor
    {
        public decimal salary;

        public CEO(string Name)
        {            
        }
    }  

}

