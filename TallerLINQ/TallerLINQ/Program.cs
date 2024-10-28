using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerLINQ
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Parte 1: Ejemplo Básico de LINQ con Números
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = from numero in numeros
                               where numero % 2 == 0
                               select numero;

            Console.WriteLine("Números Pares:");
            foreach (var numero in numerosPares)
            {
                Console.WriteLine(numero);
            }

            // Parte 2: Consultas en Colecciones
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante { Id = 1, Nombre = "Ana", Edad = 20 },
                new Estudiante { Id = 2, Nombre = "Carlos", Edad = 22 },
                new Estudiante { Id = 3, Nombre = "Juan", Edad = 19 },
                new Estudiante { Id = 4, Nombre = "Maria", Edad = 21 }
            };

            // Filtrado de estudiantes mayores de 20 años
            var estudiantesMayoresDe20 = from estudiante in estudiantes
                                         where estudiante.Edad > 20
                                         select estudiante;

            Console.WriteLine("\nEstudiantes Mayores de 20 Años:");
            foreach (var estudiante in estudiantesMayoresDe20)
            {
                Console.WriteLine(estudiante.Nombre);
            }

            // Parte 3: LINQ to SQL
            string connectionString = @"server=Al-hp; database=EscuelaDB; integrated security=true";
            DataClasses1DataContext db = new DataClasses1DataContext(connectionString);

            var estudiantesMayoresDe20SQL = from estudiante in db.Estudiantes
                                            where estudiante.Edad > 20
                                            select estudiante;

            Console.WriteLine("\nEstudiantes Mayores de 20 Años (LINQ to SQL):");
            foreach (var estudiante in estudiantesMayoresDe20SQL)
            {
                Console.WriteLine(estudiante.Nombre);
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
