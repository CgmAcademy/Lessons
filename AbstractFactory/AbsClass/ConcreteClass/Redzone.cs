using AbstractFactory.AbsClass;
using System;

namespace AbstractFactory.ConcreteClass
{
    /// <summary>
    /// The 'ProductA2' class
    /// </summary>

    class Redzone : CovidFactory
    {
        public Redzone()
        {
            _restrictionType = "Vaccine";
        }
        public override void Needs()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine(_restrictionType);
            Console.ResetColor();
         
        }
    }
}
    