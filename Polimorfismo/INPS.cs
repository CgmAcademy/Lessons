using System;

namespace Polimorfismo
{
    public class INPS
    {
        public static void ProfiloPensione(Labor Labor)
        {
            Console.WriteLine($" Profilo lavoratore:");
            Console.WriteLine($" NOME:  {Labor.Name}");
            Console.WriteLine($" PROFESSIONE:  {Labor.Contract}");
            Console.WriteLine($" STIPENDIO - Euro {Labor.Stipendio}");
            Console.WriteLine($" CF - {Labor.CF}");
            Console.WriteLine($" ------------------");
        }
    }
}