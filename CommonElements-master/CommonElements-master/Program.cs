using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 2, 4, 6, 8, 10 };
        int[] array2 = { 3, 4, 7, 8, 11 };

        int[] commonElements = FindCommonElements(array1, array2);

        Console.WriteLine("Common elements between the two arrays:");
        foreach (int num in commonElements)
        {
            Console.Write(num + " ");
        }
        Console.ReadLine();
    }

    static int[] FindCommonElements(int[] arr1, int[] arr2)
    {

        List<int> commonList = new List<int>();


        foreach (int num1 in arr1)
        {

            foreach (int num2 in arr2)
            {

                if (num1 == num2)
                {
                    commonList.Add(num1);
                    break;
                }
            }
        }


        return commonList.ToArray();
    }
}