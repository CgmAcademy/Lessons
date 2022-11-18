using System;

namespace Exception.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Order(8);// Close Program
                ConfirmOrder();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }
        static void Order(int order)
        {
            try
            {
                Payment(8);
               // ConfirmOrder();// non esesguito
            }            
            //catch (System.Exception ex)
            //{
            //    
            //}
            finally
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Close DB connection");
                Console.ResetColor();               
            }
            // Se inserisco un Catch dopo il finally continua l'esezuzione fino alla fine metodo
            Console.WriteLine("statement 1");
            Console.WriteLine("statement 2");
            Console.WriteLine("statement 3");
            Console.WriteLine("statement 4");
           
        }
        static int Payment(decimal number)
        {
           // decimal result = number / 0; 
            throw new System.Exception("Problema inserimento ordine element! "); 
        }
        static void ConfirmOrder()
        {
            Console.WriteLine("Open DB connection...");
            Console.WriteLine("Order Confirmed");
        }


    }
}
