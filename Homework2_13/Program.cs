﻿/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


Console.Write("Введите число и нажмите Enter: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (99 < x || x <= 999)
    {
        Console.WriteLine(x % 10);
    }
    else
    {
        if (999 < x || x <= 9999)
        {
            x = x / 10 % 10;
            Console.WriteLine(x);
        }

        /*else
        {
            Console.WriteLine("попробуйте другое число");
        }*/
    }
}



