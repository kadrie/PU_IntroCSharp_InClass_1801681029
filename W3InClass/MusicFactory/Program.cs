using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer = Console.ReadLine();


            if (answer=="Yes")
            {
             
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\W3\PU_IntroCSharp_InClass_1801681029\W3InClass\MusicFactory\Music\Deeperise - One By One ft. Jabbar (online-audio-converter.com).wav"))
                {
                    Console.WriteLine("Now Playing...");
                    player.PlaySync();
                    while (true) ;
                }
            }
            else if (answer=="No")
            {
                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("Your option is invalid.");
            }
            



            
            

        }
    }
}
