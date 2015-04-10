using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile3
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean i = true;
            int e = 0, cont = 1,j=0;
            Console.WriteLine("ejercicio While 3" + "\n\n\n");
            Console.Write("digite cantidad de numeros:   ");
            e = int.Parse(Console.ReadLine());


            while (i)
            {
                Console.Write("digite valor"+cont+": ");
                j = j+int.Parse(Console.ReadLine());

                if (cont == e)
                {
                    i = false;
                }
                cont++;

            }
            Console.WriteLine("suma:   "+j);
            Console.WriteLine("promedio:   " + j/e);

            Console.ReadKey();





















        }
    }
}
