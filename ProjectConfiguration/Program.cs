using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
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


            services.AddSingleton<Settings>(); // Add Settings as Singleton
            services.AddTransient<EmailService>(); // Add Settings as Singleton

            //config.Bind("mail");  // binding here 
            //config.Bind("social");
            //services.AddSingleton<IConfiguration>(config); // Add DI for IConfiguration as Singleton

            OptionsConfigurationServiceCollectionExtensions
              .Configure<Settings>(services, config.GetSection("settings"));


            var serviceProvider = services.BuildServiceProvider();    
            var receiver = serviceProvider.GetService<EmailService>(); // Get class as a Service 

            receiver.SendMail(""); // Call  Service  
            
          
        }

    }
     class EmailService
    {
        static Server _Server;        
        
        public EmailService(IConfiguration configuration)
        {

            _Server =   new  Server(
                configuration.GetValue<string>("settings:mail:SMTP"),
                configuration.GetValue<string>("settings:mail:POP")
                ); 
        }
        public EmailService(IOptions<Settings> setting)
        {

            _Server = new Server(
                setting.Value.mail.stmp,
                setting.Value.mail.pop
                );
        }
        public void SendMail(string Msg)
        {   
            _Server.SendMail($"Sending mail with \n {_Server._SMTP} and {_Server._POP} !");
        }
        class  Server
        {
            public string _POP;
            public string _SMTP;
            public Server(string SMTP, string POP)
            {
                _POP = POP;
                _SMTP = SMTP;
            }
            public void SendMail(string Msg)
            {
               /// Console.WriteLine($"Sending mail {Msg}"); 
            }
        }
    }
    interface ISettings
    {

    }
    public class Settings : ISettings
    {
        public Social social { get; set; }
        public Mail mail { get; set; }

        public class Mail
        {
            public string stmp { get; set; }
            public string pop { get; set; }
        }
        public class Social
        {
            public string facebook { get; set; }
            public string google { get; set; }
        }


    }
}

