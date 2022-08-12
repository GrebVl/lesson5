/*
Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] FillArray(int size)
{
    int[] Arr = new int[size];
    Random rdm = new Random();

    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = rdm.Next(-100, 100);
    }
    return Arr;
}

void PrintArray(int[] Array)
{
    for (int j = 0; j < Array.Length; j++)
    {
        Console.Write(Array[j] + " ");
    }
}

Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine());

int[] firstArray = FillArray(length);
PrintArray(firstArray);
Console.WriteLine();

int sum = 0;

for (int count = 1; count < length; count += 2)
{
    if (count % 2 > 0)
    {
        sum += firstArray[count];
    }
}
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + sum);
