using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectConfiguration
{
    internal class Program
    {
        static void Main(string[] args)
        {

      
            var services = new ServiceCollection();    
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            config.Bind("settings");  // binding here 
            services.AddSingleton<IConfiguration>(config);// Add DI for IConfiguration 
            services.AddSingleton<Settings>(); // Add Settings as Singleton
            var serviceProvider = services.BuildServiceProvider();    
            var receiver = serviceProvider.GetService<Settings>(); // Get class as a Service 

            receiver.GetName(); // Call  Service 
            
          
        }

    }
     class EmailService
    {
        static Server _Server;
        
        public void ConfigureMail(IConfiguration configuration)
        {
           // _Server = new Server(settings.SMTP, settings.POP);
        }
        public void SendMail(string Msg)
        {
            _Server.SendMail("Hello world!");
        }
        class  Server
        {
            string _POP;
            string _SMTP;
            public Server(string SMTP, string POP)
            {
                _POP = POP;
                _SMTP = SMTP;
            }
            public void SendMail(string Msg)
            {
                Console.WriteLine($"Sending mail {Msg}"); 
            }
        }
    }
    interface ISettings
    {

    }
    public class Settings : ISettings
    {
        public string SMTP { get; set; }
        public string POP { get; set; }
        public Settings(IConfiguration config)
        {
            SMTP = config.GetValue<string>("settings:SMTP");   
            POP = config.GetValue<string>("settings:POP"); 
        } 
        public void GetName()
        {
            Console.WriteLine($"SMTP: {SMTP}");
            Console.WriteLine($"POP: {POP}");
        }
        
        
    }
}

