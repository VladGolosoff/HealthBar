using System;

namespace HealthBar 
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            // Переменные для хранения здоровья и маны
            int health = 5, maxHealth = 10;
            int mana = 9, maxMana = 10;
            
            // Перывый вызов отрисовки полос
            Console.Clear();
            DrawBar(health, maxHealth, ConsoleColor.Red,0);
            DrawBar(mana, maxMana, ConsoleColor.Blue,1);

            Console.SetCursorPosition(0, 5);

            //Ввод значений здоровья
            bool correctValue = false;
            while(!correctValue)
            {
                Console.WriteLine("Введите количество здоровья(0-10): ");
                int tempHealth = Convert.ToInt32(Console.ReadLine());
                if (tempHealth >= 0 && tempHealth <= 10)
                {
                    health = tempHealth;
                    correctValue = true;
                }
                else
                {
                    Console.WriteLine("Неверное значение");
                }

            }
            correctValue = false;

            //Ввод значений маны
            while(!correctValue)
            {
                Console.WriteLine("Введите количество маны(0-10): ");
                int tempMana = Convert.ToInt32(Console.ReadLine());
                if (tempMana >= 0 && tempMana <= 10)
                {
                    mana = tempMana;
                    correctValue = true;
                }
                else
                {
                    Console.WriteLine("Неверное значение");

                }
            }

            //Второй вызов отрисовки полос
            Console.Clear();
            DrawBar(health, maxHealth, ConsoleColor.Red,0);
            DrawBar(mana, maxMana, ConsoleColor.Blue,1);
            Console.ReadLine();
            Console.Clear(); 
        }

        // Функция отрисовки полосы
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