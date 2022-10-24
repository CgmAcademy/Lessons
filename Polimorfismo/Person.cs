namespace Polimorfismo
{
    public class Person
    {
        public string Name { get; set; } 
        public string CF { get; set; }
        public string DataNascita { get; set; } 

        public virtual void GetName()
        {
            System.Console.WriteLine("From Person ");
        }
    }
}