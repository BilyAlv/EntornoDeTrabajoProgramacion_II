using System;

namespace PracticaBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar nombre 
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            // Solicitar edad
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            // Verificar si es mayor de edad
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }

            // Imprimir números del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}


