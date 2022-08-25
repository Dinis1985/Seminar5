// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// Пример:
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
    return array;
}

void PrintArray(double[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}   ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}


double[] DiffMaxMin(double[] array)
{
    double maxElem = array[0];
    double minElem = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (maxElem < array[i])
        {
            maxElem = array[i];
        }
        if (minElem > array[i])
        {
            minElem = array[i];
        }  
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами -> {maxElem - minElem}");
    return array;
}

double[] arr = CreateArrayRndInt(9, 1, 100);
PrintArray(arr);
double[] diffMaxMin = DiffMaxMin(arr);
