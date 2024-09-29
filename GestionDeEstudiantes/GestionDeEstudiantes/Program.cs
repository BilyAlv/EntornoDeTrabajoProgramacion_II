using System;
using System.Collections.Generic;

class Program
{
    static List<Estudiante> estudiantes = new List<Estudiante>();
    static Queue<Cliente> colaClientes = new Queue<Cliente>();
    static Stack<Tarea> pilaTareas = new Stack<Tarea>();

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Agregar Estudiante");
            Console.WriteLine("2. Eliminar Estudiante");
            Console.WriteLine("3. Mostrar Estudiantes");
            Console.WriteLine("4. Agregar Cliente");
            Console.WriteLine("5. Atender Cliente");
            Console.WriteLine("6. Agregar Tarea");
            Console.WriteLine("7. Marcar Tarea como Completada");
            Console.WriteLine("8. Mostrar Tareas Pendientes");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarEstudiante();
                    break;
                case 2:
                    EliminarEstudiante();
                    break;
                case 3:
                    MostrarEstudiantes();
                    break;
                case 4:
                    AgregarCliente();
                    break;
                case 5:
                    AtenderCliente();
                    break;
                case 6:
                    AgregarTarea();
                    break;
                case 7:
                    MarcarTareaComoCompletada();
                    break;
                case 8:
                    MostrarTareas();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 0);
    }

    // Métodos para manejar estudiantes
    static void AgregarEstudiante()
    {
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la calificación del estudiante: ");
        int calificacion = Convert.ToInt32(Console.ReadLine());
        estudiantes.Add(new Estudiante(nombre, calificacion));
        Console.WriteLine($"Estudiante {nombre} agregado.");
    }

    static void EliminarEstudiante()
    {
        Console.Write("Ingrese el nombre del estudiante a eliminar: ");
        string nombre = Console.ReadLine();
        var estudiante = estudiantes.Find(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (estudiante != null)
        {
            estudiantes.Remove(estudiante);
            Console.WriteLine($"Estudiante {nombre} eliminado.");
        }
        else
        {
            Console.WriteLine($"Estudiante {nombre} no encontrado.");
        }
    }

    static void MostrarEstudiantes()
    {
        Console.WriteLine("\nLista de Estudiantes:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Calificación: {estudiante.Calificacion}");
        }
    }

    // Métodos para manejar clientes
    static void AgregarCliente()
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        colaClientes.Enqueue(new Cliente(nombre));
        Console.WriteLine($"Cliente {nombre} agregado a la cola.");
    }

    static void AtenderCliente()
    {
        if (colaClientes.Count > 0)
        {
            Cliente clienteAtendido = colaClientes.Dequeue();
            Console.WriteLine($"Atendiendo a {clienteAtendido.Nombre}.");
        }
        else
        {
            Console.WriteLine("No hay clientes en la cola.");
        }
    }

    // Métodos para manejar tareas
    static void AgregarTarea()
    {
        Console.Write("Ingrese la descripción de la tarea: ");
        string descripcion = Console.ReadLine();
        pilaTareas.Push(new Tarea(descripcion));
        Console.WriteLine($"Tarea '{descripcion}' agregada.");
    }

    static void MarcarTareaComoCompletada()
    {
        if (pilaTareas.Count > 0)
        {
            Tarea tareaCompletada = pilaTareas.Pop();
            Console.WriteLine($"Tarea '{tareaCompletada.Descripcion}' marcada como completada.");
        }
        else
        {
            Console.WriteLine("No hay tareas pendientes.");
        }
    }

    static void MostrarTareas()
    {
        Console.WriteLine("\nLista de Tareas Pendientes:");
        foreach (var tarea in pilaTareas)
        {
            Console.WriteLine($"Descripción: {tarea.Descripcion}");
        }
    }
}

class Estudiante
{
    public string Nombre { get; set; }
    public int Calificacion { get; set; }

    public Estudiante(string nombre, int calificacion)
    {
        Nombre = nombre;
        Calificacion = calificacion;
    }
}

class Cliente
{
    public string Nombre { get; set; }

    public Cliente(string nombre)
    {
        Nombre = nombre;
    }
}

class Tarea
{
    public string Descripcion { get; set; }

    public Tarea(string descripcion)
    {
        Descripcion = descripcion;
    }
}
