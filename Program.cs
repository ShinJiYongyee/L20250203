using System;

namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            for (int j = 0; j < 5; j++)
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
