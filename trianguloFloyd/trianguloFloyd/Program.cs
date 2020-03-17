using System;

namespace trianguloFloyd
{
    class Program
    {
        static void Main(string[] args)
        {
            int coluna = 1;
            int contador = 1;


            while (contador<6) {
                
                while (coluna <= contador) {
                    if (coluna % 2 == 0) {
                        Console.Write("0");

                    }
                    if (coluna % 2 != 0) {
                        Console.Write("1");

                    }
                    
                    coluna++;



                }
                contador++;
                coluna = 1;
                Console.WriteLine("");
            }
            

        }
    }
}
