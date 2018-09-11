using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180911_AlbinAmandaHannibalRobert {
    class HannibalF {
        public static string item = "";
        public static string färg = "";


        public static void MatainStory() {


            Console.WriteLine("Välj ett vapen?");
            item = Console.ReadLine();
            Console.WriteLine($"Vilken färg har { item }");
            färg = Console.ReadLine();


        }

        public static void SkrivStory() {
            Console.WriteLine($"Alright!! Nu så är det dags att använda din { färg } { item } och rädda { Albin.inputResmal }");


        }

    }
}
