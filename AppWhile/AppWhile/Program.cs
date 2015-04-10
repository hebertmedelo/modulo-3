using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int piezas, cantidad, contador;
            float longitud;
            Console.Write("Digete numero de piezas ");
            piezas = int.Parse(Console.ReadLine());
            contador = 1;
            while (contador <= piezas)
            {
                Console.WriteLine("Digite longitud ");
                
                longitud = float.Parse(Console.ReadLine());
                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    Console.WriteLine("La Pieza " + contador + " es apta");
                }
                else
                {
                    Console.WriteLine("La Pieza " + contador + " no es apta");
                }
                contador++;

            }
            Console.ReadKey();

        }
    }
}
