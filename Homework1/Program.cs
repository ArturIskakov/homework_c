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
    max = a;
    Console.Write("max = ");
    Console.WriteLine(max);
}