using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9};
            Console.WriteLine("enter the no between 1 to 9");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("the element is " + arr[i] + " at index " + i);
                }
                 
            }
            Console.ReadLine();
        }
    }
}
