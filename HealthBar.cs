using System;

namespace HealthBar 
{
    internal class Program
    {
        int health = 50;
        int maxHealth = 100;

        private static void Main(string[] args)
        {
            DrawBar(50, 100, ConsoleColor.Red);
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += " ";
            }

            Console.SetCursorPosition(0, 0);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }
            Console.Write(bar + "]");


        }
    }
}