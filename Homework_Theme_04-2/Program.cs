using System;

// * Задание 2
// Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
// 
// При N = 9. Треугольник выглядит следующим образом:
//                                 1
//                             1       1
//                         1       2       1
//                     1       3       3       1
//                 1       4       6       4       1
//             1       5      10      10       5       1
//         1       6      15      20      15       6       1
//     1       7      21      35      35       21      7       1
//                                                              
// 
namespace Homework_Theme_04_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Кодировка вывода консоли
            Console.WriteLine("Программа: Треугольник Паскаля");
            Console.Write($"Введите количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int c = 1;
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("   ");
                }

                for (int x = 0; x <= i; x++)
                {
                    Console.Write("   {0:D} ", c);
                    c = c * (i - x) / (x + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();

            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля
            Console.WriteLine("Программа: Треугольник Паскаля (Упрощённая версия)");
            Console.Write($"Введите количество столбцов: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int c = 1;
                for (int j = 0; j < b - 1; j++)
                {
                    Console.Write("   ");
                }

                for (int x = 0; x <= i; x++)
                {
                    Console.Write("   {0:D} ", c);
                    c = c * (i - x) / (x + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();



        }

    }
}
