using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180911_AlbinAmandaHannibalRobert
{
    class Albin
    {
        public static string inputResmal;
        public static string inputSong;

        public static void AskQuestions()
        {
            Console.WriteLine("Nämn en plats: ");
            inputResmal = Console.ReadLine();
            Console.WriteLine("Nämn en sång med lite jävlar anamma i: ");
            inputSong = Console.ReadLine();

        }

        public static void PrintStory()
        {

            Console.WriteLine($"Nu bär det iväg till { inputResmal }!" +
                    $" När du anländer pumpar {inputSong} i högtalarna. " +
                    $"Fuck vad skönt med lite semester.");
        }
    }
}
