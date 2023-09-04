using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int targetValue = 50;

        int index = SearchArray(numbers, targetValue);

        if (index != -1)
        {
            Console.WriteLine($"The target value {targetValue} was found at index {index}.");
        }
        else
        {
            Console.WriteLine($"The target value {targetValue} was not found in the array.");
        }
    }

    static int SearchArray(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
        Console.ReadLine();
    }
}