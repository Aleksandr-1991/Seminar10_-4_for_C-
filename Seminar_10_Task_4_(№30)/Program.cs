// Зад 30: Прога выводит массив [8], заполненный 0 и 1-ми в случ-порядке [1,0,1,1,0,1,0,0].
int[]array1 = new int[8];
void fillArray(int[] array)
{
    for (int i=0; i < array.Length; i++)   // - решение через цикл for
    {
        array[i] = new Random().Next(2);  // Next(0, 2) - равноценно
        Console.Write(array[i] + " ");
    }
/*перенос строки */       Console.WriteLine(); 

    foreach (int element in array)    // - решение через цикл foreach
    {
        array[element] = new Random().Next(2); 
        Console.Write(array[element] + " ");
    }
}
fillArray(array1);
/*перенос строки */       Console.WriteLine();   
Console.Write("[" + String.Join(", " , array1) + "]");  // String.Join запомнить!