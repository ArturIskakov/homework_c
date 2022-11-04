// Максимум из 9 чисел

/*int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = { 14, 22, 37, 412, 59, 63, 71, 87, 59 };
//array[0] = 12;

//Console.WriteLine(array[5]);

int result1 = Max(array[0], array[1], array[2]);
int result2 = Max(array[3], array[4], array[5]);
int result3 = Max(array[6], array[7], array[8]);
int result = Max(result1, result2, result3);
Console.WriteLine(result);*/

// Одномерный массив array из n элементов, требуется найти элемент массива find

/*int[] array = { 14, 22, 37, 412, 59, 63, 71, 87, 59 };

int n = array.Length;

int find = 59;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;            //index=index+1;
}*/

// Массив с использованием Метода

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;              // index = index + 1;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int[] array = new int[10];   // создать новый массив в котором 10 элементов

FillArray(array);
PrintArray(array);