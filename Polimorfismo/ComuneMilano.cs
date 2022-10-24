using System;

namespace Polimorfismo
{
    public class ComuneMilano
    {  
        public static void ProfiloCittadino(Person person)
        {
            Console.WriteLine($" Profilo cittadino:");
            Console.WriteLine($" NOME:  {person.Name}");
           // Console.WriteLine($" PROFESSIONE:  {person.Contract}");
           // Console.WriteLine($" STIPENDIO - Euro {person.Stipendio}");
            Console.WriteLine($" CF - {person.CF}");
            Console.WriteLine($" ------------------");
        }
    }
}
