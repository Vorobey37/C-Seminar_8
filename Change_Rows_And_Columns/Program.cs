/*
Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/

using System;
using static System.Console;
Clear();

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

int [,] ChangeRowsAndColumns(int [,]array)
{
    int [,] array1 = new int [array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0) != array.GetLength(1))
    {
        WriteLine ("Это сделать невозможно!");
        return new int [0,0];
    }
    for (int i = 0; i<array1.GetLength(0); i++)
    {
        for (int j=0; j<array1.GetLength(1); j++)
        {
            array1 [i, j] = array [j, i];
        }
    }
    return array1;
}

int[,] array = GetArray(5, 6);
PrintArray(array);
WriteLine();
int[,] array1 = ChangeRowsAndColumns(array);
PrintArray(array1);
