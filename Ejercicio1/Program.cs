using System;
using System.Collections.Generic;

class Program
{
    static Queue<Proyecto> proyectos = new Queue<Proyecto>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar Proyecto");
            Console.WriteLine("2. Mostrar Proyectos");
            Console.WriteLine("3. Concluir Proyecto");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarProyecto();
                    break;
                case "2":
                    MostrarProyectos();
                    break;
                case "3":
                    ConcluirProyecto();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void AgregarProyecto()
    {
        Console.Write("Ingrese el identificador del proyecto: ");
        string identificador = Console.ReadLine();

        Console.Write("Ingrese la descripción del proyecto: ");
        string descripcion = Console.ReadLine();

        Console.Write("Ingrese la prioridad del proyecto (alta o baja): ");
        string prioridad = Console.ReadLine();

        Proyecto proyecto = new Proyecto(identificador, descripcion, prioridad);

        // Colocar proyectos de alta prioridad en la parte superior de la cola
        if (prioridad == "alta")
        {
            proyectos.Enqueue(proyecto);
        }
        else
        {
            proyectos.Enqueue(proyecto);
        }
    }

    static void MostrarProyectos()
    {
        Console.WriteLine("\nLista de Proyectos:");
        foreach (Proyecto proyecto in proyectos)
        {
            Console.WriteLine($"Identificador: {proyecto.Identificador}, Descripción: {proyecto.Descripcion}, Prioridad: {proyecto.Prioridad}");
        }
    }

    static void ConcluirProyecto()
    {
        if (proyectos.Count == 0)
        {
            Console.WriteLine("No hay proyectos en la lista.");
        }
        else
        {
            Proyecto proyectoConcluido = proyectos.Dequeue();
            Console.WriteLine($"Proyecto concluido - Identificador: {proyectoConcluido.Identificador}, Descripción: {proyectoConcluido.Descripcion}, Prioridad: {proyectoConcluido.Prioridad}");
        }
    }
}

class Proyecto
{
    public string Identificador { get; set; }
    public string Descripcion { get; set; }
    public string Prioridad { get; set; }

    public Proyecto(string identificador, string descripcion, string prioridad)
    {
        Identificador = identificador;
        Descripcion = descripcion;
        Prioridad = prioridad;
    }
}
