using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180911_AlbinAmandaHannibalRobert
{
    class Amanda
    {
        public static string animal;
        public static string name;
        public static string mode;
        public static void Animal ()
        {
            Console.Write("Skriv ett djur: ");
            animal = Console.ReadLine();


            Console.Write("Skriv ett namn:");
            name = Console.ReadLine();

            Console.Write("Vilket humör är du på: ");
            mode = Console.ReadLine();
        }
        public static void AnimalStory ()
        {
            Console.WriteLine("En {0} som heter {1} och är väldigt {2} idag.", animal, name, mode);
        }
    }

}
