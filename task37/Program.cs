/*
 Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21
*/

int[] FillArray(int num)
{
    int[] mass = new int[num];
    Random ran = new Random();

    for (int i = 0; i < num; i++)
    {
        mass[i] = ran.Next(-100, 100);
    }
    return mass;
}

void PrintArray(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + " ");
    }
}

Console.WriteLine("Введите длину массива:");
int length = int.Parse(Console.ReadLine());

int[] Array = FillArray(length);
PrintArray(Array);
Console.WriteLine();

int[] result;

if (Array.Length % 2 == 0)
{
    result = new int[Array.Length / 2];
}
else
{
    result = new int [Array.Length / 2 + 1];
}

for (int i = 0, j = Array.Length - 1; i < j; i++, j--)
{
    result[i] = Array[i] * Array[j];
}
if (Array.Length % 2 != 0)
{
    result[result.Length - 1] = Array[Array.Length / 2 ];
}

PrintArray(result);
                                                                            