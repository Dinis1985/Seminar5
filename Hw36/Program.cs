// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// Пример:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] GetSumOddInd(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNeg += array[i];
        else sumPos += array[i];
    }

    return new int[] { sumNeg, sumPos };
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] sumOddInd = int[] GetSumOddInd(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях (индексах) -> {sumOddInd[0]}");
