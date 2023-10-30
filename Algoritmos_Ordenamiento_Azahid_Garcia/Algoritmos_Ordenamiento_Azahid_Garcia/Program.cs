using System;
using System.Collections.Generic;

class SortingAlgorithms
{
    static void Main(string[] args)
    {
        int[] unsortedArray = GenerateRandomArray(10);

        Console.WriteLine("Lista no ordenada:");
        PrintArray(unsortedArray);

        int[] bubbleSortedArray = BubbleSort(unsortedArray);
        Console.WriteLine("\nOrdenado con Bubble Sort:");
        PrintArray(bubbleSortedArray);

        int[] quickSortedArray = QuickSort(unsortedArray);
        Console.WriteLine("\nOrdenado con Quick Sort:");
        PrintArray(quickSortedArray);

        int[] radixSortedArray = RadixSort(unsortedArray);
        Console.WriteLine("\nOrdenado con Radix Sort:");
        PrintArray(radixSortedArray);

        int[] shellSortedArray = ShellSort(unsortedArray);
        Console.WriteLine("\nOrdenado con Shell Sort:");
        PrintArray(shellSortedArray);

        int[] mergeSortedArray = MergeSort(unsortedArray);
        Console.WriteLine("\nOrdenado con Merge Sort:");
        PrintArray(mergeSortedArray);
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100);
        }
        return array;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] BubbleSort(int[] arr)
    {
        // Implementación del algoritmo de ordenamiento Burbuja
        // ...
        return arr;
    }

    static int[] QuickSort(int[] arr)
    {
        // Implementación del algoritmo de ordenamiento QuickSort
        // ...
        return arr;
    }

    static int[] RadixSort(int[] arr)
    {
        // Implementación del algoritmo de ordenamiento RadixSort
        // ...
        return arr;
    }

    static int[] ShellSort(int[] arr)
    {
        // Implementación del algoritmo de ordenamiento ShellSort
        // ...
        return arr;
    }

    static int[] MergeSort(int[] arr)
    {
        // Implementación del algoritmo de ordenamiento MergeSort
        // ...
        return arr;
    }
}
