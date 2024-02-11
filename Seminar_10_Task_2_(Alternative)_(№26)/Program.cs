// // Альтерантивное решение задачи по подсчёту размерности числа (ч/з строку).
int Print (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
static int DigitsNumber (int value)
{
    value = value>0 ? value : -value; //- Запомнить!
    string number = value.ToString();
    return number.Length;
}
int number = Print("Введите число:  ");
Console.Write($"Кол-во цифр в данном числе: {DigitsNumber(number)}");