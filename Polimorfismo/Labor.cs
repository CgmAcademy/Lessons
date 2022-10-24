namespace Polimorfismo
{
    public class Labor : Person
    {  
        public string Contract { get; set; }    
        public decimal Stipendio { get; set; }
        public override void GetName()
        {
            System.Console.WriteLine("From Labor ");
        }
    }
}