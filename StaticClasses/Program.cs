using System;

namespace StaticClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() { Marca = "FIAt", Name = "punto", Ruote = 4 };
            Car car2 = new Car() { Marca = "FIAt", Name = "punto", Ruote = 4 };
            Car car3 = new Car() { Marca = "FIAt", Name = "punto", Ruote = 4 };
            Car car4 = new Car() { Marca = "FIAt", Name = "punto", Ruote = 4 };

            Console.WriteLine("Frena car 1: ");
            car1.Frena();

            Console.WriteLine("Frena car 2: ");
            car2.Frena();

            Console.WriteLine("Frena car 3: ");
            car3.Frena();

            Console.WriteLine("Frena car 4: ");
            car4.Frena();


            Console.WriteLine($"Tesla -  Franate di tutte le macchine : {Car.frenate} ");
            



        }
    }
    public class Car
    {
        public static int frenate = 0;
        public int fuel = 10;
        public string Name;
        public int Ruote;
        public string Marca;

        public static int GetFrena()
        {  
            return frenate;
        }

        public void Frena()
        {
            frenate++;
        }
        public void Accelera()
        {
            fuel--;
            Console.WriteLine(fuel);
        } 

        public int GetFrena2()
        {
            return frenate;
        }
    }
}
