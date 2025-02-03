using System;

namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    *
            //   **
            //  ***
            // ****
            //*****

            for (int j = 1; j <= 5; j++)
            {
                for (int i = 0; i < 5-j; i++)
                {
                    Console.Write(' ');
                }
                for (int i = 0; i < j; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            
        }
    }
}
