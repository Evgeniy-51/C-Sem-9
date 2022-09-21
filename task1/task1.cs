using System;
// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.Clear();

Random rnd = new Random();
int lines = rnd.Next(3, 9);
int columns = rnd.Next(3, 9);
int minLim = 0;
int maxLim = 99;
int[,] arr = new int[lines, columns];

for (int i = 0; i < lines; i++)  // Заполнение массива случайными числами
{
    int minVal = minLim;
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = rnd.Next(minLim, maxLim);
        Console.Write(arr[i, j] + "\t");
    }
    System.Console.WriteLine();
}
Console.WriteLine(new string('_', columns * 8));

int temp = 0;
for (int i = 0; i < lines; i++)  // Пузырьковая сортировка
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < columns - j - 1; k++)
        {
            if (arr[i, k] < arr[i, k + 1])
            {
                temp = arr[i, k];
                arr[i, k] = arr[i, k + 1];
                arr[i, k + 1] = temp;
            }
        }
    }
}

for (int i = 0; i < lines; i++)  // Вывод массива
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(arr[i, j] + "\t");
    }
    System.Console.WriteLine();
}