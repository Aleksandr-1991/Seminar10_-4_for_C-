// Альтерантивное решение задачи по подсчёту размерности числа (ч/з строку).

int Print (string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
static int DigitsNumber (int value)
{
    if (value < 0)
    {
        value *= -1;
    }
    string number = value.ToString();
    return number.Length;
}
int number = Print("Введите число:  ");
Console.Write($"Кол-во цифр в данном числе:  {DigitsNumber(number)}");