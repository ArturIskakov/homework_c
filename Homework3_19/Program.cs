// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckNumb(string number)
{
    if (number[0]==number[4] || number[1]==number[3])
    {
        Console.WriteLine($"Число: {number} - является палиндромом.");
    }
    else Console.WriteLine($"Число: {number} - не является палиндромом.");
}

if (number!.Length == 5)
{
    CheckNumb(number);
}
else Console.WriteLine($"Вы ввели не пятизначное число, введите заного");