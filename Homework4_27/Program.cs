/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int summa(int numb)
{
    int sum = 0;
    while (numb / 10 != 0)
    {
        sum = sum + numb % 10;
        numb = numb / 10;
    }
    return sum + numb;
}

Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр вашего числа = " +summa(numb));