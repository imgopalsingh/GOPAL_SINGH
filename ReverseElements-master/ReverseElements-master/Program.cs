using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3, 4, 5, 6, 7,8,9};
            
            for(int i=arr.Length; i>=0;i--)
            {
                =arr[i];
            }
            Console.WriteLine(arr);
            
            Console.Read();

        }
    }
}
