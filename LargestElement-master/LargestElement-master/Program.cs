using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 65, 75, 84, 55, 87, 99 };
            int max = 0;
            for(int i =0;i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max= arr[i];

                }
               
            }
            Console.WriteLine( "Largest no is : "+max);
            Console.ReadLine();

        }
    }
}
