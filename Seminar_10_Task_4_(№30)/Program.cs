// Зад. 30: Нап программу, кот выводит массив из 8 элементов, 
// заполненный нулями и 1-ми в случайном порядке [1,0,1,1,0,1,0,0].
int[]array = new int[8];

void fillArray(int[] array){
int index = 0;
while (index < array.Length)
    {
    array[index] = new Random().Next(2); // Next(0, 2) - равноценно
    Console.Write(array[index] + " ");
    index++;
    }
}
fillArray(array);