using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateValueFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 1,3,4,2,2,2,2};
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count = count + 1;
                    }
                }
                Console.WriteLine(arr[i]+" Repeats "+count+ " times.");
                
            }
            Console.ReadLine();

        }
    }
}
