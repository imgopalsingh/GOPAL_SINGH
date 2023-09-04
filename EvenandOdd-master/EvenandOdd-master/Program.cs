using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenandOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 33, 6, 8, 6, 9, 10, 22, 54 };
            int Even=0;
            int Odd=0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i]%2 == 0)
                {
                    Even++;
                }
                else
                {
                    Odd++;
                }
            }
            Console.WriteLine("even numbers are : " + Even);
            Console.WriteLine("odd numbers are : " + Odd);
            Console.ReadLine();
        }
    }
}
