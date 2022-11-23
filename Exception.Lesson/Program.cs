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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;               
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }          
        }
        static void Order(int order)
        {
            try
            {
                Payment(8);
               // ConfirmOrder();// non esesguito
            }

            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("Guarda che stai cercando di dividere per 0");
                throw;
            }
            //catch (System.Exception ex)
            //{
                
            //}
            finally
            {
              //  Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Close DB connection");
              //  Console.ResetColor();               
            }
            // Se inserisco un Catch dopo il finally continua l'esezuzione fino alla fine metodo
            Console.WriteLine("statement 1");
            Console.WriteLine("statement 2");
            Console.WriteLine("statement 3");
            Console.WriteLine("statement 4");
           
        }
        static decimal Payment(decimal number)
        {
            return number;

        }
        static void ConfirmOrder()
        {
            Console.WriteLine("Open DB connection...");
            Console.WriteLine("Order Confirmed");
        }


    }
}
