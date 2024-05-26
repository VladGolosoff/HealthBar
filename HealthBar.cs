using System;

namespace HealthBar 
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            int health = 50, maxHealth = 100;
            int mana = 90, maxMana = 100;

            DrawBar(health, maxHealth, ConsoleColor.Red,0);
            DrawBar(mana, maxMana, ConsoleColor.Blue,1);
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += " ";
            }

            Console.SetCursorPosition(0, position);
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