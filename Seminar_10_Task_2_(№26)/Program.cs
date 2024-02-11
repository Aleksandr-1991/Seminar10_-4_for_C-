// Зад 26:  Нап программу, кот приним на вход число и выдаёт кол-во цифр в числе.
int GetNumber () 
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int CountElements (int number)
{   
    int count = 1;
 // while (number/10 != 0) {number /= 10; count++;}
    for (; number/10 != 0; count++) number /= 10;
    return count;
}
int getNumber = GetNumber();
int Size = CountElements(getNumber);
Console.Write("Размерность числа: " + Size);