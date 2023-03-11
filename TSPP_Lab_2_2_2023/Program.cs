//TSPP_Lab_2_2_2023 Виведення значень функції з заданого діапазону з кроком.
using System;
namespace TSPP_Lab_2_2_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, dx;
            do
            {
                Console.Write("\nВведiть значення початку дiапазону обрахунку a=");
                string T1 = Console.ReadLine();
                a = double.Parse(T1);
                Console.Write("Введiть значення кiнця дiапазону обрахунку b=");
                string T2 = Console.ReadLine();
                b = double.Parse(T2);
                Console.Write("Введiть значення кроку для проведення обрахунку dx=");
                string T3 = Console.ReadLine();
                dx = double.Parse(T3);
                if ((b - a) / dx < 2)
                {
                    Console.WriteLine($"\n Введений Вами дiапазон [а={a:f2}; b={b:f2}] та крок dx = {dx:f2} " +
                        $"\n не дозволяють отримати декiлькох значень Х. \n При цьому обрахунок не має сенсу \n Задайте iншi числа \n");
                }
                }
            while (((b - a) / dx) < 2);
            Console.Clear();
            Console.WriteLine($"\t  Результати обчислення функцiї y=Exp(x)/(3x-12)\n\tна промiжку [{a:f2}; {b:f2}] та з кроком dx = {dx:f2}");
            Console.WriteLine(" _________________________________________________________");
            Console.WriteLine(" | \t Значення x \t | \t Значення у = f(x) \t |");
            for (double x = a; x <= b; x = x + dx)
            {
                if (x != 4)
                {
                    double y = (float)(Math.Exp(x)) / (3 * x - 12);
                    Console.WriteLine(" |-----------------------|-------------------------------|");
                    Console.WriteLine($" | \t {x:f2} \t \t | \t {y:f2} \t \t ");
                }
                else
                {
                    Console.WriteLine(" |-----------------------|-------------------------------|");
                    Console.WriteLine($" | \t {x:f2} \t \t |    Помилка! Дiлення на 0 ");
                }
            }
            Console.WriteLine(" |-----------------------|-------------------------------|");
            Console.ReadLine();
        }
    }
}
