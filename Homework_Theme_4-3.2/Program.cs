using System;

namespace Homework_Theme_4_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |


            // Приветствие программы и ввод данных для генерирования матриц
            #region Приветствие программы и ввод данных для генерирования матриц
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Кодировка вывода консоли
            Console.WriteLine("Программа сложения и вычитания матриц");
            Console.WriteLine("Максимальное количество столбцов и строк не может превышать 20");
            Console.WriteLine("Введите количество строк в матрице");
            int col = Convert.ToInt32(Console.ReadLine()); // Ввод количества строк в матрице
            // Пока пользователь не введёт корректную цифру цикл будет повторяться
            while (col < 0 || col > 20)
            {
                Console.WriteLine("Максимальное количество столбцов и строк не может превышать 20");
                Console.WriteLine("Повторно введите количество строк в матрице");
                col = Convert.ToInt32(Console.ReadLine());                
            }

            Console.WriteLine("Введите количество столбцов в матрице");
            int row = Convert.ToInt32(Console.ReadLine()); // Ввод количества столбцов в матрице
            // Пока пользователь не введёт корректную цифру цикл будет повторяться
            while (row < 0 || row > 20)
            {
                Console.WriteLine("Максимальное количество столбцов и строк не может превышать 20");
                Console.WriteLine("Повторно введите количество столбцов в матрице");
                row = Convert.ToInt32(Console.ReadLine());
            }

            int[,] myArrayFirst = new int[col, row]; // Первая матрица где столбцы и строки ввёл пользователь
            int[,] myArraySecond = new int[col, row]; // Вторая матрица где столбцы и строки ввёл пользователь
            Random random = new Random();
            #endregion
            // Генерирование и вывод матриц на экран
            #region Генерирование и вывод матриц на экран
            Console.WriteLine($"Первая матрица");
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    myArrayFirst[i, j] = random.Next(-10, 10); // Диапазон значения элементов в матрице
                    Console.Write($"{myArrayFirst[i, j],5} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine($"Вторая матрица");
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    myArraySecond[i, j] = random.Next(-10, 10);
                    Console.Write($"{myArraySecond[i, j],5} ");
                }
                Console.WriteLine("");
            }
            #endregion
            #region Сложение или вычитание матриц
            Console.WriteLine("Какое действие произвести с матрицами: сложение или вычитание?");
            Console.WriteLine("Введите \"addition\" для сложения или \"subtract\" для вычитания ");
            string userAnswer = Console.ReadLine();
            while (userAnswer != "addition" || userAnswer != "Exit")
            {
                // Если ответ addition, то матрицы складываются и выводятся на экран
                if (userAnswer == "addition")
                {
                    Console.WriteLine("asdsdasd");
                    Console.WriteLine("Матрица после сложения");
                    for (int i = 0; i < col; i++)
                    {
                        for (int j = 0; j < row; j++)
                        {
                            myArrayFirst[i, j] += myArraySecond[i, j];
                            Console.Write($"{myArrayFirst[i, j],5} ");
                        }
                        Console.WriteLine("");
                        
                    }
                    Console.ReadKey();
                    break;
                }
                // Если ответ subtract, то матрицы вычитаются и выводятся на экран
                if (userAnswer == "subtract")
                {
                    Console.WriteLine("Матрица после вычитания");
                    for (int i = 0; i < col; i++)
                    {
                        for (int j = 0; j < row; j++)
                        {
                            myArrayFirst[i, j] -= myArraySecond[i, j];
                            Console.Write($"{myArrayFirst[i, j],5} ");
                        }
                        Console.WriteLine("");
                    }
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Введите \"addition\" для сложения или \"subtract\" для вычитания ");
                userAnswer = Console.ReadLine();
            }
            #endregion





        }
    }
}
