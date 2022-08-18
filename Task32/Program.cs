// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max) {
    
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++) {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

bool FindNumerFave(int[] array, int number) {
    bool j = false;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == number) j = true;  
    }
    return j;
}

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(10, 1, 10);
PrintArray(arr);
bool a = FindNumerFave(arr, num);
if (a) Console.WriteLine("Да");
else Console.WriteLine("Нет");


// Вариант2
// int[] CreateArrayRndInt(int size, int min, int max) 
// {
    
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++) 
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// } 

// void PrintArray(int[] array) 
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++) 
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write(array[i]);
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// void ChangePoseOnNegative(int [] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] *= - 1;
//     }
// }

// int[] arr = CreateArrayRndInt(4, -10, 10);
// PrintArray(arr);
// ChangePoseOnNegative(arr);
// PrintArray(arr);
