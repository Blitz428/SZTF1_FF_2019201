using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelevesFeladat
{
    class Tablagenerator
    {

        int dbx;
        int dby;
        string[,] tabla;
        int n;


        public Tablagenerator(int n, string[,] tabla) //létrehozza, és kiírja a játéktáblát a megadott 'n' paraméter alapján
        {
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {

                    if (i == 0 && j == 0)
                    {
                        tabla[i, j] = "x/y";



                    }
                    else if (i == 0 && i <= n)
                    {
                        tabla[i, j] = dbx.ToString();
                        dbx++;

                    }

                    else if (j == 0 && j <= n)
                    {
                        tabla[i, j] = dby.ToString() + "  ";
                        dby++;
                    }
                    else
                    {
                        
                        tabla[i, j] = "@";
                        
                    }
                    
                }

            }
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    
                    Console.Write(tabla[i, j] + " | ");
                }
                
                Console.WriteLine();
            }
            


        }
    }
}
