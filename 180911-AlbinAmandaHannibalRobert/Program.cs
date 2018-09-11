using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180911_AlbinAmandaHannibalRobert {
    class Program {
        static void Main(string[] args) {
            Amanda.Animal();
            Amanda.AnimalStory();
            Console.WriteLine("Nämn en plats: ");
            string inputResmal = Console.ReadLine();
            Console.WriteLine("Nämn en sång med lite jävlar anamma i: ");
            string inputSong = Console.ReadLine();

            Console.WriteLine($"Nu bär det iväg till { inputResmal }!" +
                $" När du anländer pumpar {inputSong} i högtalarna. " +
                $"Fuck vad skönt med lite semester.");
        }
    }
}
