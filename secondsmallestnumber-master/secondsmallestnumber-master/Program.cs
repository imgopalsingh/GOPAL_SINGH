using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 9, 3, 7, 6, 4 };

        int secondSmallest = FindSecondSmallest(numbers);

        Console.WriteLine("The second smallest element is: " + secondSmallest);
    }

    static int FindSecondSmallest(int[] arr)
    {
        if (arr.Length < 2)
        {
            throw new ArgumentException("Array must have at least two elements.");
        }


        Array.Sort(arr);


        int secondSmallest = arr[1];
        return secondSmallest;
        Console.ReadLine();
    }
}