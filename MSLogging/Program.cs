using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MSLogging
{
    public class Program
    {
        static ILogger logMyClass;
        public Program(ILogger logger)
        {
            logMyClass = logger;
        }
        public static void Main()
        {
            var services = new ServiceCollection().AddLogging(logging => logging.AddConsole());
            services.AddSingleton<MyClass>();//Singleton or transient?!
            //services.AddSingleton<Program>();//Singleton or transient?!
            var s = services.BuildServiceProvider();
            var myclass = s.GetRequiredService<MyClass>();
            logMyClass = s.GetRequiredService<ILogger<Program>>();   
            logMyClass.LogCritical("From Program");
            MyClass.DoSomething();
        }
        
        
        class MyClass
        {
            static ILogger logMyClass;
            public MyClass(ILogger<MyClass> logger)
            {
                logMyClass = logger;
            }
            public static void DoSomething()
            {               
                logMyClass.LogInformation("From MyClass");
            }
        }

    }
}
