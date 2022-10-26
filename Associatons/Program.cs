using System;
using System.Security.Cryptography.X509Certificates;
using Associatons.Aggregation;
using Associatons.Composition;

namespace Associatons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aggregation
            Manager Pelè = new Manager("CT");
            Employee employee = new Employee(Pelè, "Pelè");

            Manager Maradonna = new Manager("CT");
            employee.UpdateManager(Maradonna);
            #endregion

            #region Compositon

            #endregion

        }
    }  
}
    
