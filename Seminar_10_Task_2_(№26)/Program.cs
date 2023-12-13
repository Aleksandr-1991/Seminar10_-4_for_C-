// Зад 26:  Нап программу, кот приним на вход число и выдаёт кол-во цифр в числе.
int GetNumber () 
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int CountElements (int number)
{   
    int count = 1;
    while (number/10 != 0) {number = number/10; count++;}
    return count;  // - если использовать цикл for, то return count не видит переменную count
}
int getNumber = GetNumber();
int Size = CountElements(getNumber);
Console.Write("Размерность числа: " + Size);