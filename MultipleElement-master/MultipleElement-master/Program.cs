using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int factor = 3;

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        MultiplyArrayByFactor(numbers, factor);

        Console.WriteLine("\nArray after multiplication:");
        PrintArray(numbers);
    }

    static void MultiplyArrayByFactor(int[] arr, int factor)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= factor;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}