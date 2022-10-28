using System;
using System.Linq;
using System.Reflection;

namespace Arrays
{
    internal class Program
    {


        static void Main(string[] args)
        {

            // DichiarazioneDinamica();
            Car.Elimina();

            //try
            //{
            //    string[] names = new string[3];
            //    names[0] = "Bruno";
            //    names[1] = "Luca";
            //    names[2] = "Luca";
            //    names[3] = "Luca";

            //   // IndexOutOfRangeException
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Errore nell'Array:" + ex.Message);
            //}
            //catch (Exception ex) 
            //{

            //    Console.WriteLine("Errore generico!");

            //}

        }
        public static void DichiarazioneDinamica()
        {
            string[] cities = new string[] { "Milano", "Roma", "Napoli" };
            Console.WriteLine(cities[0]);
            Console.WriteLine(cities[1]);
            Console.WriteLine(cities[2]);
            cities[3] = "Treviso";
            Console.WriteLine(cities[3]);



        }
        static void Arrayloop()
        {
            int[] myArray = new int[] { 1, 2, 3 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

        }
        static void LINQMethods()
        {
            int[] ints = new int[] { 1, 2, 3 };

            Console.WriteLine(ints.Max());
            Console.WriteLine(ints.Min());
            Console.WriteLine(ints.Sum());
        }
        static void FindItem()
        {
            string[] items = { "Bruno", "Marco", "Elena", "Fabio" };
            var result = Array.Find(items, i => i.Equals("bruno"));


        }
        static void startsWithB()
        {
            string[] items = { "Bruno", "Barco", "Elena", "Fabio" };
            var result = Array.FindAll(items, i => i.StartsWith("B"));


        }
        static void FindByLength()
        {
            string[] items = { "Bruno", "Marco", "Elena", "Fabio" };
            var result = Array.Find(items, i => i.Length == 5);

        }
        static void FindLastValuestartWithB()
        {
            string[] items = { "Bruno", "Marco", "Elena", "Fabio", "Emma" };
            // var result = Array.FindLast(items, i => i.StartsWith("E")); 
            var result = items.Where(name => name.StartsWith("E")).ToList();

        }
        static void ArrayOfObjects()
        {
            //Car[] cars = new Car[10];
            //cars[0] = new Car("FIAT");
            //cars[1] = new Car("BMW");
            //cars[2] = new Car("AUDI");


            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[1].Ruote);
            //}
        }


    }
    public class Car
    {
        const int index = 5;
        string nome;

        public Car(string Name)
        {
           nome= Name;    
        }
        public static void CreateArray(int index)
        {
            string[] myArray = new string[index];// 
            index = 10; // ERROR 

        } 
        public static void Elimina()
        {
            Car[] cars = new Car[10];
            cars[0] = new Car("AUDI");
            cars[1] = new Car("BMW");

              Car[] Result = cars.Where(i => i != null && !i.Equals("AUDI")).ToArray();

             var array1=  CopyArray(cars, Result); 
        } 
        public static Car[] CopyArray(Car[] src, Car[] dest)
        {
            var newArray = new Car[src.Length];

            for (int i = 0; i < dest.Length; i++)
            {
                newArray[i] = dest[i];
            }
            return newArray; 
        }

    }

    

}
