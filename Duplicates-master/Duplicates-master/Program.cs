using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 6, 8, 3, 2, 6, 9, 8, 10, 5 };

        int[] uniqueNumbers = RemoveDuplicates(numbers);

        Console.WriteLine("Array after removing duplicates:");
        foreach (int num in uniqueNumbers)
        {
            Console.Write(num + " ");
        }
        Console.ReadLine();
    }

    static int[] RemoveDuplicates(int[] arr)
    {
        List<int> uniqueList = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in arr)
        {
            if (!seen.Contains(num))
            {
                uniqueList.Add(num);
                seen.Add(num);
            }
        }

        return uniqueList.ToArray();
    }
}