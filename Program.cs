using System;
using System.Diagnostics;

namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;
            int[,] data = new int[y,x];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = (j+1)+(i)*10;
                }
            }
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[j, i] + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
}
