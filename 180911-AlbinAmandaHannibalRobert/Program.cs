using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180911_AlbinAmandaHannibalRobert {
    class Program {
        static void Main(string[] args) {
            //First ask the questions
            Amanda.Animal();
            Albin.AskQuestions();
            HannibalF.Vapen();

            //Then print the stories
            Albin.PrintStory();
        }
    }
}
