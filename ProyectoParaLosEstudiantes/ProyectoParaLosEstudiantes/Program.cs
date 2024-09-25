using System;


namespace PracticaBasica
{
    class Program
    {
        // Ejercicio 1: Clases y Objetos
        public class Libro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int Paginas { get; set; }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Paginas: {Paginas}");
            }
        }

        // Ejercicio 2: Herencia
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        public class Estudiante : Persona
        {
            public string Grado { get; set; }

            public void MostrarInformacionEstudiante()
            {
                Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Grado: {Grado}");
            }
        }

        // Ejercicio 3: Polimorfismo y Encapsulamiento
        public class InstrumentoMusical
        {
            public virtual void Tocar()
            {
                Console.WriteLine("El instrumento está siendo tocado.");
            }
        }

        public class Guitarra : InstrumentoMusical
        {
            public override void Tocar()
            {
                Console.WriteLine("La guitarra está sonando.");
            }
        }

        public class Piano : InstrumentoMusical
        {
            public override void Tocar()
            {
                Console.WriteLine("El piano está sonando.");
            }
        }

        static void Main(string[] args)
        {
            // Ejercicio 1
            Libro libro1 = new Libro();
            libro1.Titulo = "Cien Años de Soledad";
            libro1.Autor = "Gabriel Garcia Marquez";
            libro1.Paginas = 417;
            libro1.MostrarInformacion();

            // Ejercicio 2
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Nombre = "Bily";
            estudiante1.Edad = 19;
            estudiante1.Grado = "Ingeniería";
            estudiante1.MostrarInformacionEstudiante();

            // Ejercicio 3
            List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>
            {
                new Guitarra(),
                new Piano()
            };

            foreach (var instrumento in instrumentos)
            {
                instrumento.Tocar();
            }
        }
    }
}
