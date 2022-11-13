// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write($"Задайте размер массива квадратного массива: ");
int a = InputNumbers("");
int InputNumbers(string input) // перевод введённых значений в числа

{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] CreateMatrixRndRealNum(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int row = 0;
    int col = 0;
    int x = 1;
    int y = 0;
    int ChangingDirection = 0;
    int ColumnReview = columns;
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--ColumnReview == 0)
        {
            ColumnReview = rows * (ChangingDirection % 2) + columns * ((ChangingDirection + 1) % 2) - (ChangingDirection / 2 - 1) - 2;
            int temp = x;
            x = -y;
            y = temp;
            ChangingDirection++;
        }
        col += x;
        row += y;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("");
    }
}

int[,] array2D = CreateMatrixRndRealNum(a, a);
PrintMatrix(array2D);


