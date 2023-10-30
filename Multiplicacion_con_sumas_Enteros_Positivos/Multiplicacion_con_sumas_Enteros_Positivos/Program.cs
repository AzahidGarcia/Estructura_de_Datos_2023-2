using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número entero positivo: ");
        string input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número entero positivo: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int numero1) && int.TryParse(input2, out int numero2) && numero1 >= 0 && numero2 >= 0)
        {
            int resultado = MultiplicacionPorSuma(numero1, numero2);
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        }
        else
        {
            Console.WriteLine("Los números ingresados no son enteros positivos válidos.");
        }
    }

    static int MultiplicacionPorSuma(int a, int b)
    {
        int resultado = 0;
        for (int i = 0; i < b; i++)
        {
            resultado += a;
        }
        return resultado;
    }
}
