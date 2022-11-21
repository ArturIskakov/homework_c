/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

void FillandPrint(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 20);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите координаты позиции элемента и нажмите Enter ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matr = new int[10, 10];
FillandPrint(matr);

if (m <= matr.GetLength(0) - 1)
{
    if (n <= matr.GetLength(1) - 1)
    {
        Console.Write("Значение элемента = ");
        Console.WriteLine(matr[m, n]);
    }
    /*else
    {
        Console.WriteLine("такого элемента в массиве нет.");
    }*/
}
else
{
    Console.WriteLine("такого элемента в массиве нет.");
}
