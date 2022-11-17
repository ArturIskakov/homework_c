/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Write($"Введите размер массива: ");
int array = Convert.ToInt32(Console.ReadLine());

int RandomNumb(int array, int min, int max)
{
    int[] randomNumb = new int[array];
    int sumSize = 0;
    
    for (int i = 0; i < randomNumb.Length; i++)
    {
        randomNumb[i] = new Random().Next(min, max);
        Console.Write(randomNumb[i] + " ");
        if (i % 2 != 1)
        {
            sumSize += randomNumb[i];
        }
    }
    return sumSize;
}

int randomNumb = RandomNumb(array, 1, 20);

Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
Console.WriteLine(randomNumb);