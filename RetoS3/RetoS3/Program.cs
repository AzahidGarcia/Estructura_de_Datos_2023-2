using System;

class Nodo
{
    public string Valor { get; set; }
    public string Padre { get; set; }
    public string Hermano { get; set; }
    public string HijoIzquierdo { get; set; }
    public string HijoDerecho { get; set; }

    public Nodo(string valor, string padre, string hermano, string hijoIzquierdo, string hijoDerecho)
    {
        Valor = valor == "-1" ? " " : valor;
        Padre = padre == "-1" ? " " : padre;
        Hermano = hermano == "-1" ? " " : hermano;
        HijoIzquierdo = hijoIzquierdo == "-1" ? " " : hijoIzquierdo;
        HijoDerecho = hijoDerecho == "-1" ? " " : hijoDerecho;
    }
}

class Program
{
    static Nodo[] CrearArbol()
    {
        Nodo[] arbol = new Nodo[]
        {
            new Nodo("0", "-1", "-1", "1", "2"),
            new Nodo("1", "0", "2", "3", "4"),
            new Nodo("2", "0", "1", "5", "6"),
            new Nodo("3", "1", "4", "7", "8"),
            new Nodo("4", "1", "3", "9", "10"),
            new Nodo("5", "2", "6", "11", " "),
        };

        return arbol;
    }

    static void Main()
    {
        Nodo[] arbol = CrearArbol();

        Console.WriteLine("NODO  | PADRE | HERMANO | HIJO IZQ. | HIJO DER.");
        Console.WriteLine("----------------------------------------------");

        foreach (var nodo in arbol)
        {
            Console.WriteLine($"{nodo.Valor,5} | {nodo.Padre,5} | {nodo.Hermano,8} | {nodo.HijoIzquierdo,10} | {nodo.HijoDerecho,9}");
        }
    }
}
