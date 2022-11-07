// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
    int count = 0;
    int length = cube.Length;
    while (count <  length)
    {
        cube[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 1;
    while(index < count)
    {
        Console.Write(coll[index]+ " ");
        index++;
    }
}

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);
