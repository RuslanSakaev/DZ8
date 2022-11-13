// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 arr3d 2 arr3d 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine($"Задайте размер трёхмерного массива: ");
int x = InputNumbers("Введите значение x: ");
int y = InputNumbers("Введите значение y: ");
int z = InputNumbers("Введите значение z: ");
int a = InputNumbers("Задайте числа для заполнения массива: от ");
int b = InputNumbers("Задайте числа для заполнения массива: до ");

int InputNumbers(string input) // перевод введённых значений в числа

{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,,] array3D = CreateArr3dRndRealNum(x, y, z, a, b);
PrintArray(array3D);

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] CreateArr3dRndRealNum(int r, int c, int d, int min, int max)
{
    int[,,] arr3d = new int[r, c, d];
        var rnd = new Random();
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
                arr3d[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return arr3d;
}

