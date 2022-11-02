/*
Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine(" ");
    }
}

int[,] array2D = CreateMatrixRndInt(m, n, a, b); //задали размер массива заполненный случавйными числами в диапозоне от a до b
PrintMatrix(array2D);

int RowsMinSumElements(int[,] matrix, int i) //считаем сумму элементов массива по строкам
{
    int sum = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    return sum;
}


int minSumRows = 0;
int CompareSums = RowsMinSumElements(array2D, 0);
{
    for (int i = 1; i < array2D.GetLength(0); i++)
    {
        int temp = RowsMinSumElements(array2D, i);
        if (CompareSums > temp)
        {
            CompareSums = temp;
            minSumRows = i;
        }
    }
}
Console.Write($"строкa с наименьшей суммой элементов: {minSumRows + 1} строка");

