// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.

/*Console.Write("Введите трехзначное число и нажмите Enter: ");
int x= Convert.ToInt32(Console.ReadLine());

if (x>99 || x<999)
{
    int a = (x/100);
    int b= (x-a*100)/10;
    Console.WriteLine(b);
}*/


Console.Write("Введите трехзначное число и нажмите Enter: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 99 || x < 999)
{
    x=x/10;
    Console.WriteLine(x % 10);
}