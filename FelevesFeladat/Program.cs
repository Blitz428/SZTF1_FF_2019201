using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesFeladat
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("NÉGYZETES NIM" +"\n");

            Console.WriteLine("Játékszabályok: " );
            Console.WriteLine("===============");


            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("A játékosok felváltva vesznek el a táblán elhelyezett kövekből úgy, hogy egyszerre csak egy ");
            Console.WriteLine( "oszlopból vagy egy sorból vehetnek el.Akármennyit, az egész sort vagy oszlopot is, de egy ");
            Console.WriteLine( "követ is lehet. (Legalább 1 kavicsot viszont mindenképp el kell venni.) Ami különösen fontos, ");
            Console.WriteLine( "hogy csakis egymás mellettieket vehetnek el. Tehát, ha az egyik fél elvette valamelyik sorból a ");
            Console.WriteLine("két középsőt, akkor a rákövetkező nem veheti el a maradék kettőt, csak az egyiket. \n");
            

            Console.ResetColor();

            Console.WriteLine("Mekkora legyen a játéktér? (n x n-es tábla)");
            int n = int.Parse(Console.ReadLine());


            Console.Clear();


            string[,] tabla = new string[n + 1, n + 1];

            Tablagenerator tablagenerator = new Tablagenerator(n, tabla); //létrehozza és megjeleníti a táblát

            Jatekosok jatekosok1 = new Jatekosok(); 

            Jatekosok jatekosok2 = new Jatekosok();


            Jatek jatek = new Jatek(n, jatekosok1.Jatekosnev(), jatekosok2.Jatekosnev(),tabla);
                


            Console.ReadLine();
        }
            

        
    }
}
