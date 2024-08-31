using System;

namespace Homework_Theme_4_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приветствие программы и ввод данных для генерирования матриц
            #region Приветствие программы и ввод данных для генерирования матриц
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Кодировка вывода консоли
            Console.WriteLine("Программа сложения и вычитания матриц");
            Console.WriteLine("Максимальное количество столбцов и строк не может превышать 20");
            Console.WriteLine("Введите количество строк первой матрицы");
            int colFirstMatrix = Convert.ToInt32(Console.ReadLine()); // Ввод количества строк в матрице
            // Пока пользователь не введёт корректную цифру цикл будет повторяться
            while (colFirstMatrix < 0 || colFirstMatrix > 20)
            {
                Console.WriteLine("Максимальное количество столбцов и строк не может превышать 20");
                Console.WriteLine("Повторно введите количество строк в матрице");
                colFirstMatrix = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите количество столбцов первой матрицы");
            int rowFirstMatrix = Convert.ToInt32(Console.ReadLine()); // Ввод количества строк в матрице
            // Пока пользователь не введёт корректную цифру цикл будет повторяться
            while (rowFirstMatrix < 0 || rowFirstMatrix > 20)
            {
                Console.WriteLine("Максимальное количество столбцов и строк не может превышать 20");
                Console.WriteLine("Повторно введите количество столбцов в матрице");
                rowFirstMatrix = Convert.ToInt32(Console.ReadLine());
            }

            // Вторая матрица
            Console.WriteLine("Введите количество строк второй матрицы");
            int colSecondMatrix = Convert.ToInt32(Console.ReadLine()); // Ввод количества строк в матрице
            // Пока пользователь не введёт корректную цифру цикл будет повторяться
            while (colSecondMatrix < 0 || colSecondMatrix > 20)
            {
                Console.WriteLine("Максимальное количество столбцов и строк не может превышать 20");
                Console.WriteLine("Повторно введите количество строк в матрице");
                colSecondMatrix = Convert.ToInt32(Console.ReadLine());
            }
            while (colSecondMatrix != rowFirstMatrix)
            {
                Console.WriteLine($"Количество строк во второй матрице должны быть равны количеству столбцов первой матрицы: {rowFirstMatrix}");
                Console.WriteLine("Повторно введите количество строк в матрице");
                colSecondMatrix = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите количество столбцов первой матрицы");
            int rowSecondMatrix = Convert.ToInt32(Console.ReadLine()); // Ввод количества строк в матрице
            // Пока пользователь не введёт корректную цифру цикл будет повторяться
            while (rowSecondMatrix < 0 || rowSecondMatrix > 20)
            {
                Console.WriteLine("Максимальное количество столбцов и строк не может превышать 20");
                Console.WriteLine("Повторно введите количество столбцов в матрице");
                rowSecondMatrix = Convert.ToInt32(Console.ReadLine());
            }
            #endregion


            // Вывод матриц на экран
            #region Вывод матриц на экран
            Random random = new Random();
            int[,] firstMatrix = new int[colFirstMatrix, rowFirstMatrix]; // Первая матрица, где столбцы и строки ввёл пользователь
            int[,] secondMatrix = new int[colSecondMatrix, rowSecondMatrix]; // Вторая матрица, где столбцы и строки ввёл пользователь
            Console.WriteLine($"Первая матрица");
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    firstMatrix[i, j] = random.Next(0, 10); // Диапазон значения элементов в матрице
                    Console.Write($"{firstMatrix[i, j],5} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine($"Вторая матрица");
            for (int i = 0; i < secondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    secondMatrix[i, j] = random.Next(0, 10);
                    Console.Write($"{secondMatrix[i, j],5} ");
                }
                Console.WriteLine("");
            }
            #endregion
            #region Умнжение матриц
            Console.WriteLine("Матрица после умножения");
            // создаём новую матрицу, куда заносится результат умножения
            int[,] resultMatrix  = new int [firstMatrix.GetLength(0),secondMatrix.GetLength(1)];            
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < secondMatrix.GetLength(0); k++)
                    {
                        resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];                        
                    }
                    Console.Write($"{resultMatrix[i, j],5} ");
                }
                Console.WriteLine("");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
