using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;

namespace StreamingPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamingPlatform streamingPlatform = null;  ;  
            Console.Write("Per inizare un brano premi 'M', per iniziare un film premi 'V' ");
         
            var input = char.ToUpper(Console.ReadKey().KeyChar);



            if (input == 'M')
            {
                streamingPlatform = new Spotify();

            }
            else
            {
                streamingPlatform = new Netflix(); 
            }
                
              
                    Console.WriteLine("------------------");
                       streamingPlatform.ListSongs();
                    Console.WriteLine("------------------");
                    Console.WriteLine("select Sogno number: ");
                    var i = CharUnicodeInfo.GetDecimalDigitValue(Console.ReadKey().KeyChar);
                       streamingPlatform.Play(i - 1);
                    Console.WriteLine("------------------");
                    Console.WriteLine("                   ");

                    do
                    {
                        Console.WriteLine("Next  press F: ");
                        Console.WriteLine("Previous  press B: ");
                        Console.WriteLine("Pause  Press P: ");
                        Console.WriteLine("Stop  Press S: ");

                        Console.WriteLine("--------------------------");
                        Console.WriteLine("For Exit press E: ");

                        input = char.ToUpper(Console.ReadKey().KeyChar);

                        Console.WriteLine();

                        switch (input)
                        {
                            case 'F':
                        streamingPlatform.Forward();
                                break;
                            case 'B':
                        streamingPlatform.Backward();
                                break;
                            case 'S':
                        streamingPlatform.Stop();
                                break;
                            case 'P':
                        streamingPlatform.Pause();
                                break;
                        }

                    } while (input != 'E');
                
            }
           
    }
}
