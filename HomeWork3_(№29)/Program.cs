// Дом №29. Прога задаёт массив из 8 элементов и выводит их на экран.

int Input (string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    result = result >0 ? result : -result;
    return result;
}
int[] InitArrayRandom(int lengthArray, int minRandomValue, int maxRandomValue)
{
    int[] array = new int[lengthArray];
    for (int i=0; i < lengthArray; i++)
    {
        array[i] = new Random().Next(minRandomValue, maxRandomValue + 1);
    }
return array;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");  
}

int lengthArray = Input("Введите длину массива: ");
int minRandomValue = Input( "Введите минимальное значение диапазона случайных чисел: ");
int maxRandomValue = Input("Введите максимальное значение диапазона случайных чисел: ");
int[] array = InitArrayRandom(lengthArray, minRandomValue, maxRandomValue);
PrintArray(array);