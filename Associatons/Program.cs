using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Associatons.Aggregation;
using Associatons.Composition;
using Manager = Associatons.Aggregation.Manager;

namespace Associatons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Aggregation
            //Manager Pelè = new Manager("CT"); /// DELETED
            //Employee employee = new Employee(Pelè, "Bruno");

            //Manager Maradona = new Manager("CT");

            //employee.UpdateManager(Maradona);
            //#endregion

            //#region Compositon
            //Company company = new Company("Bruno"); 
            //#endregion
            Pease italia = new Pease();
            Regione veneto = new Regione();
            veneto.pease.name;
        }
    }  

    public class Pease
    {
        public Regione regione; 
        public string name;

        public Pease()
        {
            regione = new Regione (this);
        }

    }
    public class Regione
    {
        public Pease pease;

        public string Name;
        public int popolazione;  

        public Regione(Pease Pease)
        {
            pease = Pease;
        }
    }
}
    
