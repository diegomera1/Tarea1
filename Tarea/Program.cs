using System;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de números que desea comparar");
            int cantidad = Convert.ToInt16(Console.ReadLine()), mayor = 0;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el número a comparar");
                int numero = Convert.ToInt16(Console.ReadLine());
                if (numero > mayor)
                { mayor = numero; }
            }
            Console.WriteLine("El número mayor es: {0}", mayor);
            Console.ReadKey();
        }
    }
}