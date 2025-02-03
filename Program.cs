using System;
using System.Diagnostics;
namespace L20250203
{
    public class Player
    {
        public static string Eat(string number)
        {
            return number + "을/를 먹다";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize();
            //Print();
            Console.WriteLine(Player.Eat("sex"));
        }
    }
}
