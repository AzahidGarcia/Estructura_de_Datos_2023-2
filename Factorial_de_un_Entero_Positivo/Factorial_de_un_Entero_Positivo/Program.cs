using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingrese un número entero positivo: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero) && numero >= 0)
        {
            long factorial = CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es {factorial}");
        }
        else
        {
            Console.WriteLine("El número ingresado no es un entero positivo válido.");
        }
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
