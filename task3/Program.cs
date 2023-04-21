/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] Martrix_A = new int[m, n];
CreateArray(Martrix_A);
Console.WriteLine($"\nПервая матрица:");
WriteArray(Martrix_A);

int[,] Martrix_B = new int[n, p];
CreateArray(Martrix_B);
Console.WriteLine($"\nВторая матрица:");
WriteArray(Martrix_B);

int[,] Martrix_C = new int[m,p];

MultiplyMatrix(Martrix_A, Martrix_B, Martrix_C);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(Martrix_C);

void MultiplyMatrix(int[,] Martrix_A, int[,] Martrix_B, int[,] Martrix_C)
{
  for (int i = 0; i < Martrix_C.GetLength(0); i++)
  {
    for (int j = 0; j < Martrix_C.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix_A.GetLength(1); k++)
      {
        sum += Martrix_A[i,k] * Martrix_B[k,j];
      }
      Martrix_C[i,j] = sum;
    }
  }
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
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}