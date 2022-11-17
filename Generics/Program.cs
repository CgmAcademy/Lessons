using System;
using System.Collections.Generic;

namespace GenericsLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> people = new List<Person>();
            //List<Account> conti = new List<Account>();
            //people.Add(new() { Name = "Bruno"}); 
            //people.Add(new() { Name = "Marco"});
            //people.Add(new() { Name = "Diego"});
            //people.Add(new() { Name = "Mauro"});

            //conti.Add(new() { AccountNumber = 65454515 }); 
            //conti.Add(new() { AccountNumber = 76578768 });
            //conti.Add(new() { AccountNumber = 34343454 });
            //conti.Add(new() { AccountNumber = 76865252 });
            //conti.Add(new() { AccountNumber = 13585888 });

            //GenericTextFileLogger.saveToFile<Person>(people, @"D:\logs\saveToFile.csv");

            DataStore<Person>.ShowAllM();

        }
        
    }
    public class Person
    {
        public string Name;
    }
    public class Account
    {
        public int AccountNumber;


        public void Withdraw()
        {

        }
        public void Deposit()
        {

        }
    }
}
