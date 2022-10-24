using System;

namespace Polimorfismo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Person labor = new Labor();
            labor.GetName(); 
            Labor bruno =  (Labor) labor; 
            labor.GetName(); 



            labor.Name = "Bruno";
            labor.CF = "FRBYTYHNG54656HFDG";
            labor.DataNascita = "14/01/1990";

            ComuneMilano.ProfiloCittadino(labor);

            bruno.Contract = "Web Developer";
            bruno.Stipendio =  2.000m;

            INPS.ProfiloPensione(bruno);

            Person personaLavoratore = new Person(); 
            personaLavoratore.GetName();
            //Labor Lavoratore = (Labor) personaLavoratore;
        }
    }
}

    