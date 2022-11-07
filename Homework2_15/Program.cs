// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели от 1(понедельник) до 7(воскресенье): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Этот день выходной");
    }
    else
    if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Это не день недели");
    }
    else
    {
        Console.WriteLine("Этот день не выходной");
    }
}

CheckWeek(dayNumber);

