﻿// Зад. 30: Нап программу, кот выводит массив из 8 элементов, 
// заполненный нулями и 1-ми в случайном порядке [1,0,1,1,0,1,0,0].
int[]array = new int[8];

void fillArray(int[] array)
{

    for (int i=0; i < array.Length; i++)   // - решение через цикл for
    {
        array[i] = new Random().Next(2); // Next(0, 2) - равноценно
        Console.Write(array[i] + " ");
    }

    foreach (int element in array)   // - решение через цикл foreach
    {
        array[element] = new Random().Next(2); 
        Console.Write(array[element] + " ");
    }
}
fillArray(array);