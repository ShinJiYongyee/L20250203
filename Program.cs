using System;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
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
        static int Multiply(int number1, int number2) 
        {
            return (number1 * number2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(3,4));
        }
    }
}
