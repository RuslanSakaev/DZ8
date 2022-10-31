/*
Задача 54: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.WriteLine($"Задайте размер двумерного массива: ");
int m = InputNumbers("Задайте количество строк: ");
int n = InputNumbers("Задайте количество колонок: ");
int a = InputNumbers("Задайте числа для заполнения массива: от ");
int b = InputNumbers("Задайте числа для заполнения массива: до ");

int InputNumbers(string input) // перевод введённых значений в числа
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
Console.WriteLine("Задан массив:");

int[,] array2D = CreateMatrixRndInt(m, n, a, b); //задали размер массива заполненный случавйными числами в диапозоне от a до b
PrintMatrix(array2D);
OrderByDescending(array2D);
Console.WriteLine("В итоге получается вот такой массив: ");
PrintMatrix(array2D);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) //создали массив заполненный случавйными числами
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // - rows,  строки 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // - columns, колонки
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //печать массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine(" ");
    }
}

void OrderByDescending(int[,] matrix) //Упорядочение строк массива
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}
