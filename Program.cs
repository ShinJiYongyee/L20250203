using System;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
namespace L20250203
{
    public class Player
    {
        static char wall = '*';
        static char floor = ' ';
        static int playerX = 1;
        static int playerY = 1;

        static int[,] map =               {
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 4, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };
        static ConsoleKeyInfo keyInfo;
        static bool isRunning=true;

        static void Main(string[] args)
        {
            while (isRunning) 
            {
                //Input();
                Renderer();
                Update();
                Goal();
            }
            Console.Clear();
            Console.WriteLine("Game over");
        }


        //private static void Input()
        //{
        //    keyInfo = Console.ReadKey();

        //}

        private static void Renderer()
        {
            Console.Clear();

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        Console.Write('P');
                    }
                    else if (map[y, x] == 1)
                    {
                        Console.Write(wall);
                    }
                    else if ((map[y, x] == 0))
                    {
                        Console.Write(floor);
                    }
                    else if ((map[y, x] == 4))
                    {
                        Console.Write('G');
                    }
                }
                Console.WriteLine();

            }
        }
        private static void Update()
        {
            keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow) 
            {
                playerY--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                playerY++;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                playerX--;
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                playerX++;
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                isRunning = false;
            }
        }
        private static void Goal()
        {
            if (playerX == 7 && playerY == 7)
            {
                isRunning=false;
            }
        }

    }
}
