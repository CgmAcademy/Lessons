using System;

namespace AbstractInterface.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio cerchio = new Cerchio();
               
        }
    } 

    public abstract class FiguraGeometrica
    {   
        public FiguraGeometrica()
        {

        }
        public abstract void CalcArea(); 
        public void CalcoalPerimetro()
        {
            Console.WriteLine("10.0 cm"); 
        }
    } 

    public class Triangolo : FiguraGeometrica 
    {
        public Triangolo() : base()
        {

        }
        public override void CalcArea() 
        {
            Console.WriteLine(" Base * altezza / 2");

        }
    }
    public class Square : FiguraGeometrica
    {
        public Square() : base()
        {

        }
        public override void CalcArea()
        {
            Console.WriteLine(" Lato *  Lato");

        }
    }


    public interface MediaPlayer
    {
        public int volume { get; set; }   
        public void Play(); 
    } 
    public abstract class ElectronicItem { }
    public interface Phone { }
    public class IPhone : ElectronicItem, MediaPlayer, Phone 
    {
        public int volume { get; set; }
        public void Play() 
        {
            Console.WriteLine("Apri Spotify, Premere il tasto Play"); 
        }
    }
    public class Radio : ElectronicItem, MediaPlayer
    {
        public int volume { get; set; }
        public void Play() 
        {
            Console.WriteLine(" premi tasto ON");

        }
    }
}

