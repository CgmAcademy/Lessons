using System;

namespace Refs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bruno = "Bruno";
            Person person = new Person() { Name ="Bruno"};


            ObjEditNameByLocal(ref bruno);
            Console.WriteLine($"EditedNameByLocal - {bruno} ");

            ObjEditNameByRef(person);
            Console.WriteLine($"EditedNameByRef - {person.Name} ");

            int age = 40;
            EditedByValue(age);
            Console.WriteLine($"Age after  EditedByValue - {age} ");

            EditedByRef(ref age);
            Console.WriteLine($"Age after EditedNameByRef - {age} ");


            
        }
        
        public static void ObjEditNameByRef(Person person)
        {
            person.Name = "Luca";
        }
        public static void EditedByValue(int Age)
        {
            Age = 80;// 
        }
        public static void EditedByRef(ref int Age)
        {
            Console.WriteLine($"Age before EditedNameByRef - {Age} ");
            Age = 80;
        }
        public static void ObjEditNameByLocal(ref string Name)
        {
            Name = "Luca"; // Creazione  di un nuovo oggetto
        }
    }
    
    class Person
    {
        public string Name { get; set; }
    }
}
