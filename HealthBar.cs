using System;

namespace HealthBar 
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            int health = 5, maxHealth = 10;
            int mana = 9, maxMana = 10;

            Console.Clear();
            DrawBar(health, maxHealth, ConsoleColor.Red,0);
            DrawBar(mana, maxMana, ConsoleColor.Blue,1);

            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Введите количество здоровья(0-10): ");
            int tempHealth = Convert.ToInt32(Console.ReadLine());
            if (tempHealth >= 0 && tempHealth <= 10)
            {
                health = tempHealth;
            }
            else
            {
                Console.WriteLine("Неверное значение");
            }
            Console.WriteLine("Введите количество маны(0-10): ");
            int tempMana = Convert.ToInt32(Console.ReadLine());
            if (tempMana >= 0 && tempMana <= 10)
            {
                mana = tempMana;
                Console.Clear();
                DrawBar(health, maxHealth, ConsoleColor.Red,0);
                DrawBar(mana, maxMana, ConsoleColor.Blue,1);
            }
            else
            {
                Console.WriteLine("Неверное значение");
            }


            Console.ReadLine();
            Console.Clear();


                

            
            
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