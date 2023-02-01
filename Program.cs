// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = GetArray(5, 4, 0, 99);
Console.WriteLine("Исходный массив");
PrintArray(array);
MinStringArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinStringArray(int[,] arrayforfind)
{
    int minColumn = 0;
    int minSumColumn = 0;
    int sumColumn = 0;
    for (int i = 0; i < arrayforfind.GetLength(1); i++)
    {
        minColumn += arrayforfind[0, i];
    }
    for (int i = 0; i < arrayforfind.GetLength(0); i++)
    {
        for (int j = 0; j < arrayforfind.GetLength(1); j++) sumColumn += arrayforfind[i, j];
        if (sumColumn < minColumn)
        {
            minColumn = sumColumn;
            minSumColumn = i;
        }
        sumColumn = 0;
    Console.WriteLine($"Текущая строка: {i+1}. Миниальная текущая сумма = {minColumn}. ");
    }
        Console.Write($"Строка с наименьшей суммой элементов: {minSumColumn + 1},");   
}

