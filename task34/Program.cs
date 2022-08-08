/*
Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] fillArray(int size)
{
    int[] arr = new int[size];
    Random rdm = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rdm.Next(99, 1000);
    }
    return arr;
}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}

Console.WriteLine("Введите длину массива");
int SizeArr = int.Parse(Console.ReadLine());

int[] Array = fillArray(SizeArr);
PrintArray(Array);
Console.WriteLine();

int evenNumber = 0;

for (int count = 0; count < Array.Length; count++)
{
    if (Array[count] % 2 == 0)
    {
        evenNumber++;
    }
}
Console.WriteLine("Количество четных чисел в массиве = " + evenNumber);
