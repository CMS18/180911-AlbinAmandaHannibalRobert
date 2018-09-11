using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180911_AlbinAmandaHannibalRobert
{
    class Program
    {
        static void Main(string[] args)
        {

            Formating.Format();

            //First ask the questions
            Amanda.Animal();
            Albin.AskQuestions();
            HannibalF.MatainStory();
            Robert.bil();
            Amanda.AnimalStory();


            //Then print the stories
            Albin.PrintStory();
            HannibalF.SkrivStory();
            Console.ReadLine();
        }
    }
}
