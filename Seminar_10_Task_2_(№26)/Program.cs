// Зад 26:  Нап программу, кот приним на вход число и выдаёт кол-во цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int GetNumber ()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int CountElements (int number)

{
    int count = 1;
    while (number/10 != 0)
    {
        number = number/10;
        count++;
    }
    return count;
}

int getNumber = GetNumber();
int Size = CountElements(getNumber);
Console.Write("Размерность числа: " + Size);