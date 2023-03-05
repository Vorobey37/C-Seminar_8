/*
Составить частотный словарь элементов 
двумерного массива. Частотный словарь содержит информацию о том,
сколько раз встречается элемент входных данных.

{ 1, 9, 9, 0, 2, 8, 0, 9 }

0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3,4, 6, 1, 2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
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

int[] GetOneRowArray(int[,] array)
{
    int size = array.GetLength(0) * array.GetLength(1);
    int[] oneRowArray = new int[size];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            oneRowArray[index] = array[i, j];
            index++;
        }
    }
    return oneRowArray;
}

void PrintOneRowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
}

int[] SortSizeArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void Library(int[] array)
{
    int count = 1;
    int element = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != element)
        {
            if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4) //&& count != 12 && count != 13 && count != 14)
            {
                if (count == 12 || count == 13 || count == 14)
                {
                    WriteLine($"{element} встречается {count} раз");
                }
                else
                {
                    WriteLine($"{element} встречается {count} раза");
                }
            }
            else
            {
                WriteLine($"{element} встречается {count} раз");
            }
            element = array[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{element} встречается {count} раз");
}


int[,] array = GetArray(10, 10);
PrintArray(array);
WriteLine();
int[] array1 = GetOneRowArray(array);
PrintOneRowArray(array1);
WriteLine();
int[] array2 = SortSizeArray(array1);
PrintOneRowArray(array2);
WriteLine();
Library(array2);


