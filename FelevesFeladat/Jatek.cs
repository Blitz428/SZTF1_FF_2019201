using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesFeladat
{
    class Jatek
    {
        int[] x;
        int[] y;
        int szamlalo = 1;
        int length;
        public string jelenlegiJatekos;


        public Jatek(int n, string jatekos1, string jatekos2, string[,] tabla) //az egész játék lefut
        {
            int[] x = new int[n + 1];
            int[] y = new int[n + 1];
            int length = n;

            
            string[,] ujtabla = new string[n + 1, n + 1]; //az ujtabla szükséges a kavicselvételek miatt

            Tablagenerator tablagenerator1 = new Tablagenerator(n, tabla);
            Console.Clear();
            Tablagenerator tablagenerator2 = new Tablagenerator(n, ujtabla);


            jelenlegiJatekos = jatekos1; 
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(jelenlegiJatekos + ", kérem adja meg a koordinátákat! Ha meg szeretne állni, akkor ugyanazt a koordinátát adja meg újra.");


                for (int i = 0; i < n; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;


                    Console.WriteLine(szamlalo + ". X koordináta: ");
                    x[i] = int.Parse(Console.ReadLine()) + 1;

                    Console.WriteLine(szamlalo + ". Y koordináta: ");
                    y[i] = int.Parse(Console.ReadLine()) + 1;

                    Console.Clear();
                    Console.ResetColor();


                    for (int q = 0; q < ujtabla.GetLength(0); q++)
                    {
                        for (int z = 0; z < ujtabla.GetLength(1); z++)
                        {
                            Console.Write(ujtabla[q, z] + " | ");
                        }
                        Console.WriteLine();
                    }
                    

                    if ((i - 1) != -1 && x[i] == x[i - 1] && y[i] == y[i - 1])
                    {
                        i = n;
                        
                    }
                    else
                    {
                        szamlalo++;
                    }
                }

                Console.Clear();

                for (int i = -1; i < n-1; i++)
                {
                    
                        ujtabla[x[i + 1], y[i + 1]] = tabla[x[i + 1], y[i + 1]].Replace('@', ' ');
                    
                            
                }

                Console.ResetColor();


                for (int i = 0; i < ujtabla.GetLength(0); i++)
                {
                    for (int j = 0; j < ujtabla.GetLength(1); j++)
                    {
                        Console.Write(ujtabla[i, j] + " | ");
                    }
                    Console.WriteLine();
                }

                if (jelenlegiJatekos == jatekos2)
                {
                    jelenlegiJatekos = jatekos1;
                }
                else
                {
                    jelenlegiJatekos = jatekos2;
                }
                szamlalo = 1;

            } while (JatekVege(ujtabla, n));

            if (jelenlegiJatekos == jatekos2)
            {
                jelenlegiJatekos = jatekos1;
            }
            else
            {
                jelenlegiJatekos = jatekos2;
            }


            Console.WriteLine("Gratulálok, " + jelenlegiJatekos + " nyert!");
            
        }

        static bool JatekVege(string[,]ujtabla, int n) //megnézi, hogy teljesen üres-e a játéktér
        {
            int db = 0;

            for (int i = 0; i < ujtabla.GetLength(0); i++)
            {
                for (int j  = 0; j < ujtabla.GetLength(1); j++)
                {
                    if (ujtabla[i,j]==" ")
                    {
                        db++;
                    }
                }
            }
            if (db==(n*n))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        

        

        
    }



}