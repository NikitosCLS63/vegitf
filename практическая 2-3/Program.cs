using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Main_Menu();
    }

    public static void ugady_chislo()
    {
        Random random = new Random();
        int random_number = random.Next(0, 100);
        while (true)
        {
            Console.Write("Введите число: ");
            int user_number = Convert.ToInt32(Console.ReadLine());
            if (user_number == random_number)
            {
                Console.WriteLine("Поздравляю, вы назвали правильное число!");
                break;

            }
            else if (user_number < random_number)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        }
    }



    public static void umnojit_Table()
    {
        int[,] table = new int[10, 10];
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                table[i - 1, j - 1] = i * j;
            }
        }
        Console.WriteLine("Таблица умножения:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void delit_chislo()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        List<int> divisors = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
            }
        }
        Console.WriteLine("Делители числа {0}: {1}", number, string.Join(", ", divisors));
    }

    public static void Main_Menu()
    {
        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите программу (введите номер): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                ugady_chislo();
            }
            else if (choice == 2)
            {
                umnojit_Table();
            }
            else if (choice == 3)
            {
                delit_chislo();
            }
            else if (choice == 0)
            {
                break;

            }
            else
                Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
        }

    }
}
