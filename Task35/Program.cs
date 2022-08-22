// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// доработать?
int[] randomАrray = CreateArrayRndInt(5, 0, 200);
int Count(int[] randomАrray); 
{
    int count = 0;
    for (int i = 0; i < randomАrray.Length; i++)
    {
        if(randomАrray[i] >= 10 && randomАrray[i] <= 99)
        count++;  
    }
    return count;
}
PrintArray(randomАrray);
Console.WriteLine(Count(randomАrray));
