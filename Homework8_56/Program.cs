/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

void FillMatrix(int[,] matr)
{
    Random rnd = new Random();
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = matr[m, n] = rnd.Next(1, 20);
        }
    }
}
void PrintMatrix(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write(matr[m, n] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
int min = int.MaxValue;
int index = 0;
for (int m = 0; m < matrix.GetLength(0); m++)
{
    int summ = 0;
    for (int n = 0; n < matrix.GetLength(1); n++)
    {

        summ = summ + matrix[m, n];
    }
    if (summ < min)
    {
        min = summ;
        index++;
    }
}
Console.Write("Наименьшая сумма элементов в строке № ");
Console.WriteLine(index);