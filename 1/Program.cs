
/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write($"Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);

double[,] RandomArray(int m, int n)
{
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1}  ");
        }
        Console.WriteLine();
    }
}

double[,] array = RandomArray(m,n);
PrintArray(array);

/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

//среднее арифметическое а + b / 2

Console.Write($"Введите количество столбцов: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество строк: ");
int b = int.Parse(Console.ReadLine()!);

int[,] array = new int[a,b];

void RandomArray(int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void Sum(int[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(1):f1} ");
    }
}

RandomArray(a, b);
Console.WriteLine();
Sum(array);

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


Console.Write($"Введите количество столбцов: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество строк: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int[,] array = new int[a,b];
bool find = false;

void RandomArray(int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CheckArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(num == array[i,j])
        find = true;
    }
    }
}

RandomArray(a, b);
Console.WriteLine();
CheckArray(array);

if(find)
    Console.Write($"{num} -> такое число есть");
else
    Console.Write($"{num} -> такого числа в массиве нет");
