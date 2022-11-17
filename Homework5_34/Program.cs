/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] createArray(int n)
{
    int[] array = new int[n];
    return array;
}

int[] fillArray(int[] array, int min, int max)    // заполнение массива рандомными значениями
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = rand.Next(min, max);
    }
    return array;
}

void printArray(int[] array)     // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int countEven(int[] array)              // подсчет четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = createArray(n);
array = fillArray(array, 100, 999);

printArray(array);

Console.Write($"Чётных чисел в массиве: {countEven(array)}");