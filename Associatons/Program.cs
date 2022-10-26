using System;
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
            #region Aggregation
            Manager Pelè = new Manager("CT"); /// DELETED
            Employee employee = new Employee(Pelè, "Bruno");

            Manager Maradona = new Manager("CT");

            employee.UpdateManager(Maradona);
            #endregion

            #region Compositon
            Company company = new Company("Bruno"); 
            #endregion

        }
    }  
}
    
