using System;
using System.Diagnostics;
namespace L20250203
{
    internal class Program
    {
        static int[,] data = new int[10, 10];
        static void Initialize()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = (j+1)+(i)*10;
                }
            }
        }
        static void Print()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[j, i] + "\t ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Initialize();
            Print();
        }
    }
}
