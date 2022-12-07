using System;

namespace GB_HW52
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Введите количетсво строк: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[m, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 50);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double avg = 0;
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    avg += matrix[i, j];
                    count++;
                }
                avg /= count;
                Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {avg}");
                avg = 0;
                count = 0;
            }
        }
    }
}
