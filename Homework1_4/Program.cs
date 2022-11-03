// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = new Random().Next(-100, 100); // взял интервал от -100 до 100
int b = new Random().Next(-100, 100);
int c = new Random().Next(-100, 100);
int max = a;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);