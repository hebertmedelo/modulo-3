using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, suma, promedio;
            Console.WriteLine("Digite nota 1");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 2");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 3");
            nota3 = float.Parse(Console.ReadLine());

            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;
            if (promedio >= 3)
            {
                Console.WriteLine("Aprovado");
                Console.Write("promedio = "+promedio);
            }
            else
            {
                Console.WriteLine("Reprobado");
                Console.Write("promedio = " + promedio);
            }
            Console.ReadKey();
        }
    }
}
