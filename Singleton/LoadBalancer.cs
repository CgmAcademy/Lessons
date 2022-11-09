using System;
using System.Collections.Generic;

namespace Singleton
{
    public sealed class Proxy
        {
            private static readonly Proxy instance = new Proxy();

            private readonly List<Server> servers;
            private readonly Random random = new Random();

            private Proxy()
            {
               servers = new List<Server>();
            
                string n1;
                string n2;
                string n3;
                string n4;

                 n1 = random.Next(100,199).ToString();
                 n2 = random.Next(100,150).ToString();
                 n3 = random.Next(0,20).ToString();
                 n4 = random.Next(0, 20).ToString();
                 string Server1 = $"{n1}.{n2}.{n3}.{n4}";
                 servers.Add(new Server { Name = "ServerI", IP = Server1 });

                 n1 = random.Next(100, 199).ToString();
                 n2 = random.Next(100, 150).ToString();
                 n3 = random.Next(0, 20).ToString();
                 n4 = random.Next(0, 20).ToString();
                 string Server2 = $"{n1}.{n2}.{n3}.{n4}";

                servers.Add(new Server { Name = "ServerI", IP = Server2 });

        }

            public static Proxy GetLoadBalancer()
            {
                return instance;
            }         

            public Server NextServer
            {
                get
                {
                    int r = random.Next(servers.Count);
                    return servers[r];
                }
            }
        }
}





