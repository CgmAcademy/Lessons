using System;
using System.Collections.Generic;

namespace GenericsLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            //List<Account> conti = new List<Account>();
            people.Add(new() { Name = "Bruno", Age = 40 });
            people.Add(new() { Name = "Marco", Age = 30 });
            people.Add(new() { Name = "Diego", Age = 20 });
            people.Add(new() { Name = "Mauro", Age = 10 });

            //conti.Add(new() { AccountNumber = 65454515 }); 
            //conti.Add(new() { AccountNumber = 76578768 });
            //conti.Add(new() { AccountNumber = 34343454 });
            //conti.Add(new() { AccountNumber = 76865252 });
            //conti.Add(new() { AccountNumber = 13585888 });

            //GenericTextFileLogger.saveToFile<Person>(people, @"D:\logs\saveToFile.csv");
          var result=     GenericTextFileLogger.LoadFromTextFile<Person>(@"D:\logs\saveToFile.csv");

            foreach (var item in result)
            {
                Console.Write($"{item.Name}");
                Console.Write($" -  ");
                Console.Write($"Age: {item.Age}");
                Console.WriteLine($"  ");
            }
          //  DataStore<Person>.ShowAllM();

        }
        
    }
    public class Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }
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
