﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int num = 2;
while (num <= 15) // N = 15, можно любое поставить
{
    int result = num % 2;
    if (result !=1)
    {
        Console.WriteLine(num + " - чётное число ");
        num++;
    }
    else
    {
        num++;
    }
}