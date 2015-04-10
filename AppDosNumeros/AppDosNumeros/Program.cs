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
            float num1, num2, suma, resta, producto, divicion;
            Console.WriteLine("Digite primer numero");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo numero");
            num2 = float.Parse(Console.ReadLine());
           

       
            if (num1 > num2)
            {
                suma = num1 + num2;
                Console.WriteLine("Suma= " + suma);
                resta = num1 - num2;
                Console.WriteLine("Resta= " + resta);
            }
            else
            {
                producto = num1 * num2;

                Console.WriteLine("Producto= "+ producto);
                divicion = num1 / num2;
                Console.Write("Divicion = " + divicion);
            }
            Console.ReadKey();
        }
    }
}
