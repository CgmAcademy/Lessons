using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectConfiguration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Settings settings = new Settings();
            //settings.POP = "pop3.libero.it";
            //settings.SMTP = "smtp.libero.it";
            //EmailService.SendMail(settings.SMTP, settings.POP); 

            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            Settings settings = config.GetRequiredSection("settings").Get<Settings>();
            Console.WriteLine(settings.POP);
            Console.WriteLine(settings.SMTP);
            EmailService.SendMail(settings.SMTP, settings.POP);

        }

    }
    static class EmailService
    {
        static Server _Server;
        
        public static void ConfigureMail(string SMTP, string POP)
        {
            _Server = new Server(SMTP, POP);
        }
        public static void SendMail(string Msg, string POP)
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
    public class Settings
    {
        public string SMTP { get; set; }
        public string POP { get; set; }
    }
}

