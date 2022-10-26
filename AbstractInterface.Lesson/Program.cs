using System;

namespace AbstractInterface.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square cerchio = new Square();
            EuroZoneCountry italy = new EuroZoneCountry();
            italy.PopulationControl();

        }
    } 

    public abstract class FiguraGeometrica
    {
        public decimal Area; 
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
        public new decimal Area;
        public Triangolo() : base()
        {

        }
        public override void CalcArea() 
        {
            Console.WriteLine( Area);

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
    public interface IMediaPlayer
    {
        public int Volume { get; set; }   
        public void Play(); 
    } 
    public abstract class ElectronicItem { }
    public interface Phone { }
    public class IPhone : ElectronicItem, IMediaPlayer, Phone 
    {
        public int Volume { get; set; }
        public void Play() 
        {
            Console.WriteLine("Apri Spotify, Premere il tasto Play"); 
        }
    }
    public class Radio : ElectronicItem, IMediaPlayer
    {
        public int Volume { get; set; }
        public void Play() 
        {
            Console.WriteLine(" premi tasto ON");

        }
    } 
    

}

