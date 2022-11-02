using System;

namespace MemoryManagement
{
    internal class Program
    {
        static Third t = new Third();
        static void Main(string[] args)
        {            
            MyFunction(t);
        }
        public static void MyFunction(Third n)
        {
            Third p = n;
            t = null;
        }
    }
    class First
    {
        ~First()
        {
            Console.WriteLine("First's finalizer is called.");
        }
    }

    class Second : First
    {
        ~Second()
        {
            Console.WriteLine("Second's finalizer is called.");
        }
    }

    class Third : Second
    {
        ~Third()
        {
            Console.WriteLine("Third's finalizer is called.");
        }
    }
}
