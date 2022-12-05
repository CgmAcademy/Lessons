using AbstractFactory.AbsClass;
using System;

namespace AbstractFactory.ConcreteClass
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>

    class Yellowzone : CovidFactory
    {

        public Yellowzone()
        {
            _restrictionType = "Tampone";
        }
        public override void Needs()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine(_restrictionType);
            Console.ResetColor();
         
        }

    }
}
