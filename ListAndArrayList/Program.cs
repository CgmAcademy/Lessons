using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListAndArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1); 
            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add("Bruno");

            int somma = 0;

            foreach (var item in arrayList)
            {
                 
               //  Console.WriteLine(item);  

                if(item is int)
                { 
                    somma += (int) item;
                }
                 
            }
            Console.WriteLine($"Somma Numeri:{somma} ");


            Console.WriteLine("---------------------------------------------");
            List<int> values = new List<int>();
            values.Add(1);
            values.Add(2);
            values.Add(3);
            var value = values.Remove(values.Where(i => i == 1).FirstOrDefault());
            Console.WriteLine(value);
            values.ForEach(o => Console.WriteLine(o));
        }
    }
}
