using System;

namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < (j+1); i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            
        }
    }
}
