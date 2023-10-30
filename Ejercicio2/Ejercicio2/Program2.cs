using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una pila fuente
        Stack<int> pilaFuente = new Stack<int>();
        pilaFuente.Push(1);
        pilaFuente.Push(2);
        pilaFuente.Push(3);

        // Crear una pila destino
        Stack<int> pilaDestino = new Stack<int>();

        // Llamar al método para copiar la pila
        CopiarPila(pilaFuente, pilaDestino);

        // Imprimir la pila destino para verificar la copia
        Console.WriteLine("Pila Destino (copia de la pila fuente):");
        foreach (int elemento in pilaDestino)
        {
            Console.WriteLine(elemento);
        }
    }

    static void CopiarPila<T>(Stack<T> pilaFuente, Stack<T> pilaDestino)
    {
        // Crear una pila temporal para mantener el orden correcto
        Stack<T> pilaTemporal = new Stack<T>();

        // Copiar elementos de la pila fuente a la pila temporal
        foreach (T elemento in pilaFuente)
        {
            pilaTemporal.Push(elemento);
        }

        // Vaciar la pila destino (por si tenía elementos previos)
        pilaDestino.Clear();

        // Copiar elementos de la pila temporal a la pila destino
        foreach (T elemento in pilaTemporal)
        {
            pilaDestino.Push(elemento);
        }
    }
}
