// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число и нажмите Enter: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число и нажмите Enter: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a < b)
{
    max = b;
    Console.Write("max = ");
    Console.WriteLine(max);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(max);
}

// Версия 2

/*int a = new Random().Next(-100, 100); // взял интервал от -100 до 100
int b = new Random().Next(-100, 100);
int max = a;
Console.WriteLine(a);
Console.WriteLine(b);
if (a > max) max = a;
if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);*/