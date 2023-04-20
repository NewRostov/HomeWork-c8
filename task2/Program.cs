/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
*/


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите размерность m:  ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите размерность n:  ");
        int n = Convert.ToInt32(Console.ReadLine());
        int size = InputNumbers("Введите диапазон: от 1 до ");

        int[,] array = new int[m, n];
        CreateArray(array);
        WriteArray(array);

        int minSumLine = 0;
        int sumLine = SumLineElements(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSumLine = SumLineElements(array, i);
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
        }

        Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");


        int SumLineElements(int[,] array, int i)
        {
            int sumLine = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                sumLine += array[i, j];
            }
            return sumLine;
        }

        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        void CreateArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(size);
                }
            }
        }

        void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
