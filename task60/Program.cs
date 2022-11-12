// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine($"Задайте размер трёхмерного массива: ");
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

// Console.WriteLine("Введите размерность второй матрицы");
// int[,] secondMatrix = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
// for (int i = 0; i < secondMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < secondMatrix.GetLength(1); j++)
//     {
//         Console.Write("Заполните массив цифрами[{0},{1}] = ", i, j);
//         secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
//     }
// }