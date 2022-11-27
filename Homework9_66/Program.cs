/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int RecSum(int n)
{
    if (m > n) return 0;
    else return n + RecSum(n - 1);
}

Console.WriteLine("Сумма натуральных элементов в промежутке от " + m + " до " + n + " = " + RecSum(n));