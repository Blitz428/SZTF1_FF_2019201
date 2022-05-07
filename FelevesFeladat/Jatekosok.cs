using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesFeladat
{
    class Jatekosok
    {
        string jatekosnev;


        public Jatekosok()
        {
            jatekosnev = "";
        }



        public string Jatekosnev() //a játékos nevét lekérdezi és tárolja
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Játékos neve:");
            Console.ResetColor();

            jatekosnev = Console.ReadLine();

            return jatekosnev;
            

        }


   
        
        
    }
}
