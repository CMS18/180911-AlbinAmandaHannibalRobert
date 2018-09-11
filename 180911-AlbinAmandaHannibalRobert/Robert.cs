using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180911_AlbinAmandaHannibalRobert
{
    class Robert
    {
        public static string bil;
        public static void Bil()

            {

            Console.Write("Vad för bil är din favorit? ");
            bil = Console.ReadLine();
            Console.WriteLine("Din favorit är " + bil);

            }

        public static void BilStory()

            {

            Console.WriteLine($"Du är redo för ditt första uppdrag med din {0}");
            
            }


    }
}
