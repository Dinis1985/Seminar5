// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//Доработать
int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
int[] CompositionArray(int[] array)
{
    int size1 = 0;
    if(array.Length % 2 == 0) size1 = array.Length / 2;
    else size1 = (array.Length / 2) + 1;
    int[] result = new int[size1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i -1];
    }
    if(array.Length % 2 != 0) result[size1 - 1] = array[array.Length / 2];
    
    return result; 
}
int[] result = CompositionArray(array);
PrintArray(result);

