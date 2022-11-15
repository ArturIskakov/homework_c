/* Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 (2*2*2*2)
без использования math.pow*/

int stepen(int A, int B)
{
    int stepen = A;
    for (int i = 2; i <= B; i++)
    {
        stepen = stepen * A;
    }
    return stepen;
}

Console.Write("Введите число и нажмите Enter: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите cтепень и нажмите Enter: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(stepen(A, B));