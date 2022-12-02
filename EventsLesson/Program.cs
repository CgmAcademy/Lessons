using System;

namespace EventsLesson
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Slider slider = new Slider();
            slider.Name = "Bruno";
            slider.SliderChanged += new MoveEventHandler(GetOrder); // Plug-In
            slider.Position = 25;
            slider.Position = 60;

        }
        public static void SliderMove(object source, MoveEventArgs e)
        {
            if (e.newPosition < 50)
            {
                System.Console.WriteLine("Valore OK");
            }
            else
            {
                e.cancel = true;
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Non posso andare oltre");
                Console.ResetColor();
            }
        }
        public static void GetOrder(object source, MoveEventArgs e)
        {

        }

    }
}
