using System;
using System.Collections.Generic;

class Nodo
{
    public char Valor;
    public Nodo Izquierda;
    public Nodo Derecha;

    public Nodo(char valor)
    {
        Valor = valor;
        Izquierda = null;
        Derecha = null;
    }
}

class ArbolBinario
{
    public Nodo Raiz;

    public ArbolBinario()
    {
        Raiz = null;
    }

    public void Insertar(char valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodo, char valor)
    {
        if (nodo == null)
        {
            nodo = new Nodo(valor);
        }
        else if (valor < nodo.Valor)
        {
            nodo.Izquierda = InsertarRecursivo(nodo.Izquierda, valor);
        }
        else
        {
            nodo.Derecha = InsertarRecursivo(nodo.Derecha, valor);
        }
        return nodo;
    }

    public void RecorridoAnchura()
    {
        if (Raiz == null)
        {
            Console.WriteLine("El árbol está vacío.");
            return;
        }

        Queue<Nodo> cola = new Queue<Nodo>();
        cola.Enqueue(Raiz);

        while (cola.Count > 0)
        {
            Nodo nodo = cola.Dequeue();
            Console.Write(nodo.Valor + " ");

            if (nodo.Izquierda != null)
                cola.Enqueue(nodo.Izquierda);

            if (nodo.Derecha != null)
                cola.Enqueue(nodo.Derecha);
        }
    }
}

class Program
{
    static void Main()
    {
        ArbolBinario arbol = new ArbolBinario();
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        foreach (char letra in alfabeto)
        {
            arbol.Insertar(letra);
        }

        Console.WriteLine("Recorrido en anchura del árbol binario:");
        arbol.RecorridoAnchura();
    }
}
