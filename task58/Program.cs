/*
Задача 58: 
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] array2D1 = firstMatrix(m, n, a, b); //задали размер массива заполненный случавйными числами в диапозоне от a до b
Console.WriteLine("Первая матрица");
PrintMatrix(array2D1);

int[,] firstMatrix(int rows, int columns, int min, int max) //создали массив заполненный случавйными числами
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

int[,] array2D2 = secondMatrix(m, n, a, b); //задали размер массива заполненный случавйными числами в диапозоне от a до b
Console.WriteLine("Вторая матрица");
PrintMatrix(array2D2);

int[,] secondMatrix(int rows, int columns, int min, int max) //создали массив заполненный случавйными числами
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Произведение двух матриц");

int[,] resalt = MatrixMultiplication(array2D1, array2D2);
PrintMatrix(resalt);

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) throw new Exception("Матрицы нельзя пеермножить");  
    int[,] resalt = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resalt[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resalt;
}
