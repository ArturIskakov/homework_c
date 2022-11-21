/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите размер матрицы (количество строк и столбцов) через Enter ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
Random rnd = new Random();
void FillandPrintMatrix(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(0, 20);
            Console.Write(matrix[i, j] + "\t");

        }
        Console.WriteLine();
    }
}
Console.WriteLine();
FillandPrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        summ += matrix[i, j];
    }
    summ = summ / m;
    Console.Write($"{summ:f1}" + "\t");
}