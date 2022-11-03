using System;
using System.Globalization;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  DateTime currentTime = DateTime.Now;
            CalcEta();
        } 


        public static void CalcEta() 
        {  
            DateTime mybirth = new DateTime(1982, 11, 04);
                int birthday = mybirth.Day;
                int birthMonth = mybirth.Month;
                int birhYear = mybirth.Year;
                int age =  DateTime.Now.Year - birhYear; //40

           
            if(age >= 40 && DateTime.Now.Month >= birthMonth && DateTime.Now.Day >= birthday )
            {
                Console.WriteLine("E maggiorenne!");
            }
            else
            {
                Console.WriteLine($"Non sei maggionrenne perche hai ancora {age-1}");
            }
            
        }
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now.ToLocalTime());
            Console.WriteLine(DateTime.Now.ToUniversalTime());

            DateTime currentTime = DateTime.Now; 
           
            //DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")	2015-05-16T05:50:06
            //DateTime.Now.ToString("HH:mm")	05:50  --> H 24 
            //DateTime.Now.ToString("hh:mm tt")	05:50 AM
            //DateTime.Now.ToString("H:mm")	5:50 



            Console.WriteLine("Los Agenles: {0}", 
                TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, "Pacific Standard Time"));
        } 
        public static void TimezonesList(DateTime currentTime)
        {
            Console.WriteLine("Los Angeles: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Pacific Standard Time"));
            Console.WriteLine("Chicago: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Central Standard Time"));
            Console.WriteLine("New York: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Eastern Standard Time"));
            Console.WriteLine("London: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "GMT Standard Time"));
            Console.WriteLine("Moscow: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Russian Standard Time"));
            Console.WriteLine("New Delhi: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "India Standard Time"));
            Console.WriteLine("Beijing: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "China Standard Time"));
            Console.WriteLine("Tokyo: {0}",
                              TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Tokyo Standard Time"));
        } 
        public static void GetdateFromInput()
        {
            Console.WriteLine("Inserire una  data: ");
            string input = Console.ReadLine();

            DateTime result; 

           if(  DateTime.TryParse(input, out result))
            {
                Console.WriteLine($" -  TryParse {result}");
            }
            else
            {
                Console.WriteLine($" - TryParse  Failed! ");

            }

        } 
        public static void ForcingFormat()
        {

            string[] dateFormats = new string[] { "yyyy/MM/dd" }; 
            CultureInfo cultureInfo = new CultureInfo("en-US");

            Console.WriteLine("Inserire una  data: ");
            string input = Console.ReadLine();

            DateTime result;

            
            if (DateTime.TryParseExact(input, 
                dateFormats, 
                cultureInfo, 
                DateTimeStyles.AdjustToUniversal, 
                out result))
            {
                Console.WriteLine($" -  TryParse {result}");
            }
            else
            {
                Console.WriteLine($" - TryParse  Failed! ");

            }

        } 
        public static void CreateDayOfWeek()
        {
            DateTime birthday = new DateTime(1982,01,14);  
            DateTime today = DateTime.Now;


            if (birthday.DayOfWeek == today.DayOfWeek)
                Console.WriteLine("Today is the same day of your birthday!");
            else
                Console.WriteLine($"You were born on {birthday.DayOfWeek} but today is {today.DayOfWeek}");

            CultureInfo cultureInfo = new CultureInfo("fr-FR");

           var bd =   cultureInfo.DateTimeFormat.GetDayName(birthday.DayOfWeek); 
           var td =   cultureInfo.DateTimeFormat.GetDayName(today.DayOfWeek);

            if (bd == td)
                Console.WriteLine("Today is the same day of your birthday!");
            else
                Console.WriteLine($"You were born on {bd} but today is {td}");


            //DateTime myDate = new DateTime(2022,11,02,10,30,45);  
            //int year = myDate.Year;
            //int Month = myDate.Month;
            //int Day = myDate.Day;
            //int Hour = myDate.Hour;
            //int Minute = myDate.Minute;
            //int Second = myDate.Second;

        } 
        public static void AutomaticConvertion()
        {
            DateTime dateTime = DateTime.Now;

            string dateInUSA = dateTime.ToString("D", new CultureInfo("en-US"));
            string dateInFR = dateTime.ToString("D", new CultureInfo("fr-FR"));
            string dateInIT = dateTime.ToString("D", new CultureInfo("it"));
            string dateInDE = dateTime.ToString("D", new CultureInfo("de"));

            Console.WriteLine(dateInUSA);
            Console.WriteLine(dateInFR);
            Console.WriteLine(dateInIT);
            Console.WriteLine(dateInDE);
        } 
        public static void CreateTimeSpan()
        {
            TimeSpan timeSpan = new TimeSpan(30,0,0,0);

            DateTime mydate = DateTime.Now; 


            // 30 gg in piu
            DateTime mydate2 = DateTime.Now.Add(timeSpan);

            Console.WriteLine(mydate);

           
            Console.WriteLine(mydate2);


            // 120 gg in piu 
            DateTime mydate3 = DateTime.Now.AddDays(120);
            Console.WriteLine(mydate3);

            // 90 gg in piu 
            Console.WriteLine(mydate3.Subtract(timeSpan));

        }

    }
}
