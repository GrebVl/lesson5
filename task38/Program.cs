/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] FillArray(int length)
{
    int[] arr = new int[length];
    Random ran = new Random();

    for (int index = 0; index < length; index++)
    {
        arr[index] = ran.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + " ");
    }
}

Console.WriteLine("Введите длину массива:");
int size = int.Parse(Console.ReadLine());

int[] array = FillArray(size);
PrintArray(array);
Console.WriteLine();

int max = array[0];
int min = array[0];

for (int count = 0; count < size; count++)
{
    if (array[count] > max)
    {
        max = array[count];
    }
    else if (array[count] < min)
    {
        min = array[count];
    }
}
Console.WriteLine("Max = " + max);
Console.WriteLine("Min = " + min);
Console.WriteLine("Max + Min = " + (max + min));