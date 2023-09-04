using System;
namespace Average
{
    class Program
    {
        static void Main(String[] args)
        {
            float[] values = { 1.2f, 3.4f, 5.4f, 6.5f, 8.6f, 8.9f };
            float sum = 0;
            for(int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            float average = sum / values.Length;
            Console.WriteLine("the average of the values : " + average);
            Console.ReadLine();
        }
    }
}