using System;
using System.Diagnostics;

namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];

            for (int i = 0; i < data.Length; i++) 
            { 
                data[i] = i+1;
            }
            for (int i = 0;i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
