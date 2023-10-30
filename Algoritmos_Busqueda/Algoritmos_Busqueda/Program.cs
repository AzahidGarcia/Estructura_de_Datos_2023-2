using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "numeros.txt");

        if (File.Exists(filePath))
        {
            Console.WriteLine("Archivo de texto encontrado en el escritorio.");

            int[] numbers = File.ReadLines(filePath).Select(int.Parse).ToArray();

            Console.Write("Ingresa el número que deseas buscar: ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("Elige el método de búsqueda:");
            Console.WriteLine("1. Búsqueda Secuencial");
            Console.WriteLine("2. Búsqueda Binaria");
            Console.WriteLine("3. Búsqueda Hash");

            int choice = int.Parse(Console.ReadLine());

            int count = 0;

            switch (choice)
            {
                case 1:
                    count = SequentialSearch(numbers, target);
                    break;
                case 2:
                    Array.Sort(numbers);
                    count = BinarySearch(numbers, target);
                    break;
                case 3:
                    Dictionary<int, int> hashTable = CreateHashTable(numbers);
                    count = HashSearch(hashTable, target);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (count > 0)
            {
                Console.WriteLine($"El número {target} se encontró {count} veces en el archivo.");
            }
            else
            {
                Console.WriteLine($"El número {target} no se encontró en el archivo.");
            }
        }
        else
        {
            Console.WriteLine("El archivo de texto no se encuentra en el escritorio.");
        }
    }

    static int SequentialSearch(int[] array, int target)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (number == target)
            {
                count++;
            }
        }
        return count;
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        int count = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (array[mid] == target)
            {
                count++;
                int leftIndex = mid - 1;
                int rightIndex = mid + 1;
                while (leftIndex >= 0 && array[leftIndex] == target)
                {
                    count++;
                    leftIndex--;
                }
                while (rightIndex < array.Length && array[rightIndex] == target)
                {
                    count++;
                    rightIndex++;
                }
                break;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return count;
    }

    static Dictionary<int, int> CreateHashTable(int[] array)
    {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();
        foreach (int number in array)
        {
            if (hashTable.ContainsKey(number))
            {
                hashTable[number]++;
            }
            else
            {
                hashTable[number] = 1;
            }
        }
        return hashTable;
    }

    static int HashSearch(Dictionary<int, int> hashTable, int target)
    {
        if (hashTable.ContainsKey(target))
        {
            return hashTable[target];
        }
        return 0;
    }
}
