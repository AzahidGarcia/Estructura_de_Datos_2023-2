using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una frase o palabra: ");
        string entrada = Console.ReadLine();

        if (EsPalindromo(entrada))
        {
            Console.WriteLine("La frase/palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La frase/palabra NO es un palíndromo.");
        }
    }

    static bool EsPalindromo(string frase)
    {
        // Crear una pila para almacenar los caracteres de la frase
        Stack<char> pila = new Stack<char>();

        // Eliminar los espacios en blanco y convertir a minúsculas para ignorar mayúsculas y espacios
        frase = frase.Replace(" ", "").ToLower();

        // Agregar los caracteres de la frase a la pila
        foreach (char c in frase)
        {
            pila.Push(c);
        }

        // Construir una nueva cadena con los caracteres de la pila
        string reverso = "";
        while (pila.Count > 0)
        {
            reverso += pila.Pop();
        }

        // Comparar la cadena original con la cadena reversa para determinar si es un palíndromo
        return frase == reverso;
    }
}
