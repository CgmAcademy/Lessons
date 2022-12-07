using System;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncTaskLesson
{
    internal class Program
    {
          static void Main(string[] args)
        {
            Task<int[]> promise =  ApiRequest();// fermo per 5s 
            Console.WriteLine("Ho terminato il programma!");
            Console.WriteLine($"Stampa API  Result API request: {string.Join(",",promise.Result)}");
            Console.ReadLine();// tiene fermo il il programma 
        } 
        static async Task<int[]>  ApiRequest()
        {
            //Thread.Sleep();  teneva il Thread chiamante bloccato
            Console.WriteLine("ApiRequest -  started");
            //  await Task.Delay(10000); /// dice al thread chiamante di ritornare a al suo lavoro
            Console.WriteLine("Internet è lenta.....");

            return await Task.Factory.StartNew<int[]>(DatabaseQuery); 
            
        }
        static int[] DatabaseQuery()
        {
            Console.WriteLine("DatabaseQuery -  started");
            Thread.Sleep(10000); 
            Console.WriteLine("DatabaseQuery -  Finished");

            return new int[] { 1515, 5441, 8978, 51551 };

        }   static void Main(string[] args)
        {
            Task<int[]> promise =  ApiRequest();// fermo per 5s 
            Console.WriteLine("Ho terminato il programma!");
            Console.WriteLine($"Stampa API  Result API request: {string.Join(",",promise.Result)}");
            Console.ReadLine();// tiene fermo il il programma 
        } 
        static async Task<int[]>  ApiRequest()
        {
            //Thread.Sleep();  teneva il Thread chiamante bloccato
            Console.WriteLine("ApiRequest -  started");
            //  await Task.Delay(10000); /// dice al thread chiamante di ritornare a al suo lavoro
            Console.WriteLine("Internet è lenta.....");

            return await Task.Factory.StartNew<int[]>(DatabaseQuery); 
            
        }
        static int[] DatabaseQuery()
        {
            Console.WriteLine("DatabaseQuery -  started");
            Thread.Sleep(10000); 
            Console.WriteLine("DatabaseQuery -  Finished");

            return new int[] { 1515, 5441, 8978, 51551 };

        }
    }
}
