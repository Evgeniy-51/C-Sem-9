// Задача 2**. Напишите программу, которая спирально заполнит числами от 1 до 16 двумерный массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int size = 4;
int area = size;
int[,] arr = new int[size, size];
int num = 1;

for (int i = 0; i < size / 2; i++)
{
    for (int k = i; k < area - 1; k++)
    {
        arr[i, k] = num;
        num++;
    }
    for (int k = i; k < area - 1; k++)
    {
        arr[k, area - 1] = num;
        num++;
    }
    for (int k = area - 1; k > i; k--)
    {
        arr[area - 1, k] = num;
        num++;
    }
    for (int k = area - 1; k > i; k--)
    {
        arr[k, i] = num;
        num++;
    }
    area--;
}

for (int i = 0; i < size; i++)  // Вывод массива
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(arr[i, j] + "\t");
    }
    System.Console.WriteLine();
}



