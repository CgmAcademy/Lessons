using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            string balancer;

            for (int i = 0; i < 15; i++)
            {
                balancer = Proxy.GetLoadBalancer().NextServer.IP;
                Console.WriteLine("Dispatch request to: " + balancer);
            }
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < 5; i++)
            {
                balancer = Proxy.GetLoadBalancer().NextServer.IP;
                Console.WriteLine("Dispatch request to: " + balancer);
            }       
            Console.ReadKey();
        } 
       
    }
}





