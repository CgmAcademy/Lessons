using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Reflection.Intro
{
   
    class Person
    {
        public  void GetName(int x)
        {
            // no-op
        }

        public void GetAge(string x)
        {
            // no-op
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Methods.M(0);
            //Methods.M(new[] { "a", "b" });

            ShowAllM<Person>();
        }

        public static void ShowAllM<T>()
        {
            var tm = typeof(T);
            foreach (var mi in tm.GetMethods().Where(m=> m.ToString().Contains("Get")))
            {
                WriteLine(mi.Name);
                foreach (var p in mi.GetParameters())
                {
                    WriteLine($"\t{p.ParameterType.Name}");
                }
            }
        }
    }
}
